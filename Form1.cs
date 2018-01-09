using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prod_mod
{

    public partial class Form1 : Form
    {
        public string file_name;
        public List<Fact> Facts;

        public List<Rule> Rules;
        public List<Fact> True_facts;

        public Form1()
        {
            InitializeComponent();
        }


        //====================================================FACT CLASS==========================================================
        public class Fact
        {
            public string id;
            public string data;

            public Fact(string id, string data)
            {
                this.id = id;
                this.data = data;
            }

            public Fact(Fact f)
            {
                id = f.id;
                data = f.data;
            }

            public override string ToString()
            {
                    return id + ": " + data;
            }
        }



        //====================================================RULE CLASS==========================================================
        public class Rule
        {
            public string id;
            public string data;
            public List<string> left_part;
            public string right_part;

            public Rule(string id, List<string> left_part, string right_part, string data)
            {
                this.id = id;
                this.data = data;
                this.left_part = left_part;
                this.right_part = right_part;
            }

            public override string ToString()
            {
                string left_side = "";

                for (int i = 0; i < left_part.Count - 1; i++)
                {
                    left_side += left_part[i] + ", ";
                }

                left_side += left_part[left_part.Count - 1];
                return id + ": " + left_side + "  ====>  " + right_part + " " + data;
            }
        }


        //=============================================LOAD KNOWLEDGE BASE========================================================
        private void load_knowledge_base_click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_name = openFileDialog.FileName;

                //Clear previous info
                true_facts_listbox.Items.Clear();

                used_rules_listbox.Items.Clear();

                result_facts_listbox.Items.Clear();

                info_label.Text = "";

                facts_listbox.Items.Clear();
                rules_listbox.Items.Clear();

                Facts = new List<Fact>();
                Rules = new List<Rule>();
                string s;
                StreamReader sr = new StreamReader(file_name);
                while ((s = sr.ReadLine()) != null)
                {
                    string [] substr = s.Split(';');

                    //Adding facts
                    if (substr[0][0] == 'f')   
                    {
                        Facts.Add(new Fact(substr[0], substr[1]));
                        facts_listbox.Items.Add(new Fact(substr[0], substr[1]));
                    }

                    //Adding rules
                    if (substr[0][0] == 'p') 
                    {
                        string[] left_side = substr[1].Split(',');
                        List<string> left = new List<string>();
                        for (int i = 0; i < left_side.Length; i++)
                            left.Add(left_side[i]);
                        Rules.Add(new Rule(substr[0], left, substr[2], substr[3]));
                        rules_listbox.Items.Add(new Rule(substr[0], left, substr[2], substr[3]));
                    }

                }
                sr.Close();
            }
        }


        //========================================================CLEAR========================================================
        private void Clear_click(object sender, EventArgs e)
        {
            true_facts_listbox.Items.Clear();
            used_rules_listbox.Items.Clear();
            result_facts_listbox.Items.Clear();

            info_label.Text = "";
        }


        //========================================================CHOOSE FACTS========================================================
        private void Choose_facts_click(object sender, MouseEventArgs e)
        {
            int index = this.facts_listbox.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches && !true_facts_listbox.Items.Contains(facts_listbox.Items[index]))
                true_facts_listbox.Items.Add(facts_listbox.Items[index]);
        }



        //=========================================================REMOVE FACT=======================================================
        private void remove_fact_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ind = this.true_facts_listbox.IndexFromPoint(e.Location);

            if (ind != ListBox.NoMatches)
                true_facts_listbox.Items.RemoveAt(ind);
        }



        //========================================================FORWARD CHAINING====================================================
        private void forward_chaining_click(object sender, EventArgs e)
        {
            if (true_facts_listbox.Items.Count == 0)
                return;

            //clear previous info
            info_label.Text = "";

            used_rules_listbox.Items.Clear();
            result_facts_listbox.Items.Clear();

            True_facts = new List<Fact>();  
            for (int i = 0; i < true_facts_listbox.Items.Count; i++) 
                True_facts.Add((Fact)true_facts_listbox.Items[i]);

            List<Fact> res_facts;

            while (true)
            {
                res_facts = new List<Fact>();
                for (int i = 0; i < Rules.Count; ++i) 
                {
                    int matches = 0;
                    bool flag = true;

                    for (int j = 0; j < True_facts.Count; j++)
                    {
                        //if fact is the right part of the rule
                        if (True_facts[j].id.Equals(Rules[i].right_part))
                        {
                            flag = false;
                        }
                        else
                            //if left part contains true fact
                            if (Rules[i].left_part.IndexOf(True_facts[j].id) != -1)
                        {
                            matches++;
                        }
                    }     

                    //if the whole right part of the rule found
                    if (matches == Rules[i].left_part.Count && flag) 
                    {
                        for (int j = 0; j < Facts.Count; j++)
                        {
                            if (Facts[j].id == Rules[i].right_part)
                            {
                                Fact f = new Fact((Fact)facts_listbox.Items[j]);
                                res_facts.Add(f);
                                break;
                            }
                        }
                        used_rules_listbox.Items.Add(Rules[i].ToString()); 
                    }
                }

                for (int i = 0; i < res_facts.Count; i++) 
                {
                    Fact f = res_facts[i];

                    for (int j = 0; j < result_facts_listbox.Items.Count; j++)
                    {
                        if (res_facts[i].id == ((Fact)result_facts_listbox.Items[j]).id)
                            result_facts_listbox.Items.RemoveAt(j);
                    }

                    result_facts_listbox.Items.Add(f);
                    True_facts.Add(f);
                }
                if (res_facts.Count == 0)
                    return;
            } 
        }

        //============================================================================DERIVE(for backwards chaining)===========================
        private bool is_derivable(string fact_id)
        {
            for (int i = 0; i < True_facts.Count; i++)
            {
                if (True_facts[i].id == fact_id) 
                    return true;
            }

            for (int i = 0; i < Rules.Count; i++) 
                if (Rules[i].right_part == fact_id) 
                {
                    int derivable_cnt = 0;
                    //check if all tha left facts are derivable
                    for (int j = 0; j < Rules[i].left_part.Count; j++) 
                    {
                        if (is_derivable(Rules[i].left_part[j]))
                        {
                            for(int k = 0; k < True_facts.Count; k++)
                                if(True_facts[k].id == Rules[i].left_part[j])  
                                 derivable_cnt++;
                        }
                            
                    }
                    //if the whole left part is derivable
                    if(derivable_cnt == Rules[i].left_part.Count) 
                    {
                        if (!used_rules_listbox.Items.Contains(Rules[i]))
                        used_rules_listbox.Items.Add(Rules[i]);

                        for (int j = 0; j < Facts.Count; j++)
                            if (Facts[j].id == Rules[i].right_part)
                            {
                                True_facts.Add(Facts[j]);
                                break;
                            }
                        return true;
                    }
                }
            return false;
        }


        //========================================================BACKWARDS CHAINING========================================================
        private void backwards_chaining_click(object sender, EventArgs e)
        {
            if (true_facts_listbox.Items.Count == 0)
                return;

            string fact_id = textBox1.Text.ToString();

            if (fact_id == "")
                return;
            //clear previous info
            used_rules_listbox.Items.Clear();
            result_facts_listbox.Items.Clear();

            True_facts = new List<Fact>();

            for (int i = 0; i < true_facts_listbox.Items.Count; i++)
                True_facts.Add((Fact)true_facts_listbox.Items[i]);

            info_label.Text = "";
            bool derivable = this.is_derivable(fact_id);

            if (derivable)
                info_label.Text = fact_id + ": Success!";
            else
                info_label.Text = fact_id + " is not derivable!";

            for (int i = 0; i < True_facts.Count; i++)
            {
                if (True_facts[i].id == fact_id)
                    result_facts_listbox.Items.Add(new Fact(True_facts[i]));
            }

        }

    }
}
