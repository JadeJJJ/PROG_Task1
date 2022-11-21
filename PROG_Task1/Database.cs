using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PROG_Task1
{
    class Database
    {

        //public static readonly string textFile = "C:\\Users\\jadej\\source\\repos\\JadeJJJ\\PROG_Task1\\PROG_Task1\\Dewey.txt";
        public static readonly string textFile = Path.Combine(Directory.GetCurrentDirectory(), "Dewey.txt");
        public static TreeNode<string> root = new TreeNode<string>("root");
        

        public static void readData()
        {
            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                int count = -1,tracker=0;
                foreach (string line in lines)
                {

                    if(line.StartsWith("000") || line.StartsWith("100")
                        || line.StartsWith("200") || line.StartsWith("300")
                        || line.StartsWith("400") || line.StartsWith("500")
                        || line.StartsWith("600") || line.StartsWith("700")
                        || line.StartsWith("800") || line.StartsWith("900"))
                    {
                        count++;
                        root.AddChildren(line);
                    }

                    else if (line.Contains("20"))
                    {
                        root.Children[count].AddChild(line);
                        tracker = 20;
                    }
                    else if (line.Contains("30"))
                    {
                        root.Children[count].AddChild(line);
                        tracker = 30;
                    }


                    else
                    {
                        if (tracker == 20)
                        {

                            try
                            {
                                root.Children[count].Children[0].AddChild(line);
                            }
                            catch (Exception e) { }
                        }
                        else if(tracker==30)
                        {
                            try
                            {
                                root.Children[count].Children[1].AddChild(line);
                            }
                            catch(Exception e) { }
                        }

                    }


                }
            }

           

        }



    }
    }
//----------------------------------------------------END 0F PR0GR@M-------------------------------------------------------------------------------------------------
