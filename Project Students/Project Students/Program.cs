using System;
using System.Collections.Generic;
using System.Xml;





namespace Consol1
{
    class Program
    {

        static int menu()
        {
            int volba = 0;
            Console.WriteLine("1. Pridat studenta");
            Console.WriteLine("2. Odstranit studenta");
            Console.WriteLine("3. Vypsat seznam studentu");
            Console.WriteLine("4. Vypsat znamky");
            Console.WriteLine("5. Pridat znamku");
            Console.WriteLine("6. Odstranit znamku");
            Console.WriteLine("7. Nacist soubor XML");
            Console.WriteLine("8. Ulozit do souboru XML");

            Console.WriteLine(" ");
            Console.WriteLine("Zadejte jednu z moznosti (1-8)");

            try
            {
                volba = int.Parse(Console.ReadLine());
            }

            catch
            {

                Console.WriteLine(" Zadejte jednu z moznosti (1-8)!!! ");
                volba = menu();

            }


            return volba;
        }

        static void Main(string[] args)
        {
            int g = 0;
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;

            List<string> studenti = new List<string>();

            List<int> matematika = new List<int>(99);
            while (g <= 99)
            {
                matematika.Add(0);

                g++;

            }

            List<int> anglictina = new List<int>(99);
            while (g1 <= 99)
            {
                anglictina.Add(0);

                g1++;

            }

            List<int> programovani = new List<int>(99);
            while (g2 <= 99)
            {
                programovani.Add(0);

                g2++;

            }

            List<int> psychologie = new List<int>(99);
            while (g3 <= 99)
            {
                psychologie.Add(0);

                g3++;

            }

            List<int> ekonomie = new List<int>(99);
            while (g4 <= 99)
            {
                ekonomie.Add(0);

                g4++;

            }



            int odpoved = 0;
            while (odpoved < 1 || odpoved > 10)
            {

                switch (menu())
                {


                    case 1:
                        Console.Clear();
                        Console.WriteLine("Pridani studenta");
                        Console.WriteLine(" ");

                        Console.WriteLine("kolik studentu chcete zapsat?");



                        int pocetstud = Convert.ToInt32(Console.ReadLine());

                        int n = 0;

                        while (pocetstud != n)
                        {
                            Console.WriteLine("Napiste jmeno a prijmeni studenta");
                            Console.WriteLine("[Ve formatu Jmeno_Prijmeni]");
                            string stud = Console.ReadLine();
                            studenti.Add(stud);
                            n++;

                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Zapsani probehlo uspesne!");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");



                        break;






                    case 2:
                        Console.Clear();
                        Console.WriteLine("Odstraneni studenta");
                        Console.WriteLine(" ");
                        Console.WriteLine("Kolik studentu chcete odstranit");
                        Console.WriteLine("1- jedneho");
                        Console.WriteLine("2- odstranit vsechni studenti");

                        int q = Convert.ToInt32(Console.ReadLine());

                        if (q == 1)
                        {
                            int t = 0;

                            while (t != (studenti.Count))
                            {
                                Console.Write(t + 1);
                                Console.Write(".");
                                Console.Write(" ");

                                Console.WriteLine(studenti[t]);

                                t++;
                            }

                            Console.WriteLine("Napiste cislo studenta ktereho chcete odstranit");
                            int y = Convert.ToInt32(Console.ReadLine());
                            studenti.RemoveAt(y - 1);

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");



                        }

                        else
                        {
                            foreach (string a in studenti)
                                Console.WriteLine(a);

                            studenti.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine("vsechni studenti jsou smazany :'( ");
                            Console.WriteLine(" ");

                        }


                        break;






                    case 3:
                        Console.Clear();


                        Console.WriteLine("Studenti v seznamu: ");
                        Console.WriteLine(" ");


                        int i = 0;

                        while (i != (studenti.Count))
                        {
                            Console.Write(i + 1);
                            Console.Write(".");
                            Console.Write(" ");

                            Console.WriteLine(studenti[i]);

                            i++;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        break;





                    case 4:
                        Console.Clear();
                        Console.WriteLine("Vypsani znamek");

                        int i2 = 0;
                        int pu = 0;

                        Console.WriteLine("Z jakeho predmetu chcete vypsat znamky?");
                        Console.WriteLine("1. Matematika");
                        Console.WriteLine("2. Anglictina");
                        Console.WriteLine("3. Programovani");
                        Console.WriteLine("4. Psychologie");
                        Console.WriteLine("5. Ekonomie");

                        pu = Convert.ToInt32(Console.ReadLine());

                        switch (pu)
                        {

                            case 1:
                                while (i2 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(i2 + 1);
                                    Console.Write(".");
                                    Console.Write("      ");


                                    Console.Write(studenti[i2]);
                                    Console.Write("       ");
                                    Console.Write(matematika[i2]);

                                    Console.WriteLine("   ");


                                    i2++;
                                }
                                break;

                            case 2:
                                while (i2 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(i2 + 1);
                                    Console.Write(".");
                                    Console.Write("     ");

                                    Console.Write(studenti[i2]);
                                    Console.Write("       ");
                                    Console.Write(anglictina[i2]);
                                    Console.WriteLine("   ");
                                    i2++;
                                }
                                break;

                            case 3:
                                while (i2 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(i2 + 1);
                                    Console.Write(".");
                                    Console.Write(" ");

                                    Console.Write(studenti[i2]);
                                    Console.Write("       ");
                                    Console.Write(programovani[i2]);
                                    Console.WriteLine("   ");
                                    i2++;
                                }
                                break;

                            case 4:
                                while (i2 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(i2 + 1);
                                    Console.Write(".");
                                    Console.Write(" ");

                                    Console.Write(studenti[i2]);
                                    Console.Write("       ");
                                    Console.Write(psychologie[i2]);
                                    Console.WriteLine("   ");
                                    i2++;
                                }
                                break;

                            case 5:
                                while (i2 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(i2 + 1);
                                    Console.Write(".");
                                    Console.Write(" ");

                                    Console.Write(studenti[i2]);
                                    Console.Write("       ");
                                    Console.Write(ekonomie[i2]);
                                    Console.WriteLine("   ");
                                    i2++;
                                }


                                break;

                            default: Console.WriteLine("zadejte  jednu z moznosi 1-5 !"); break;


                        }



                        Console.WriteLine("   ");



                        break;


                    case 5:
                        Console.Clear();
                        int k = 0;
                        Console.WriteLine("Pridani znamky");

                        Console.WriteLine("V jakem predmetu chcete udelat znamku?");

                        Console.WriteLine("1. Matematika");
                        Console.WriteLine("2. Anglictina");
                        Console.WriteLine("3. Programovani");
                        Console.WriteLine("4. Psychologie");
                        Console.WriteLine("5. Ekonomie");

                        k = Convert.ToInt32(Console.ReadLine());

                        switch (k)
                        {
                            case 1:

                                Console.WriteLine("Jaka znamka?");
                                int zn1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(" ");
                                Console.WriteLine("jakeho studenta chcete ohodnotit?");
                                int h = 0;

                                while (h != (studenti.Count))
                                {
                                    Console.Write(h + 1);
                                    Console.Write(".");
                                    Console.Write(" ");

                                    Console.WriteLine(studenti[h]);






                                    h++;

                                }

                                int c = Convert.ToInt32(Console.ReadLine());
                                c = c - 1;



                                matematika.Insert(c, zn1);


                                break;

                            case 2:

                                Console.WriteLine("Jaka znamka?");
                                int zn2 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(" ");
                                Console.WriteLine("jakeho studenta chcete ohodnotit?");
                                int h1 = 0;

                                while (h1 != (studenti.Count))
                                {
                                    Console.Write(h1 + 1);
                                    Console.Write(".");
                                    Console.Write(" ");

                                    Console.WriteLine(studenti[h1]);


                                    h1++;
                                }

                                int c1 = Convert.ToInt32(Console.ReadLine());
                                c1 = c1 - 1;
                                anglictina.Insert(c1, zn2);

                                break;

                            case 3:
                                Console.WriteLine("Jaka znamka?");
                                int zn3 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(" ");
                                Console.WriteLine("jakeho studenta chcete ohodnotit?");
                                int h2 = 0;

                                while (h2 != (studenti.Count))
                                {
                                    Console.Write(h2 + 1);
                                    Console.Write(".");
                                    Console.Write(" ");

                                    Console.WriteLine(studenti[h2]);


                                    h2++;
                                }

                                int c2 = Convert.ToInt32(Console.ReadLine());
                                c2 = c2 - 1;
                                programovani.Insert(c2, zn3);
                                break;

                            case 4:
                                Console.WriteLine("Jaka znamka?");
                                int zn4 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(" ");
                                Console.WriteLine("jakeho studenta chcete ohodnotit?");
                                int h3 = 0;

                                while (h3 != (studenti.Count))
                                {
                                    Console.Write(h3 + 1);
                                    Console.Write(".");
                                    Console.Write(" ");

                                    Console.WriteLine(studenti[h3]);


                                    h3++;
                                }

                                int c3 = Convert.ToInt32(Console.ReadLine());
                                c3 = c3 - 1;
                                psychologie.Insert(c3, zn4);
                                break;

                            case 5:
                                Console.WriteLine("Jaka znamka?");
                                int zn5 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(" ");
                                Console.WriteLine("jakeho studenta chcete ohodnotit?");
                                int h4 = 0;

                                while (h4 != (studenti.Count))
                                {
                                    Console.Write(h4 + 1);
                                    Console.Write(".");
                                    Console.Write(" ");

                                    Console.WriteLine(studenti[h4]);


                                    h4++;
                                }

                                int c4 = Convert.ToInt32(Console.ReadLine());
                                c4 = c4 - 1;
                                ekonomie.Insert(c4, zn5);
                                break;






                            default: Console.WriteLine("zadejte  jednu z moznosi 1-5 !"); break;





                        }





                        break;





                    case 6:
                        Console.Clear();
                        Console.WriteLine("Odstraneni znamek");

                        Console.WriteLine("V jakem predmetu chcete odstranit znamku?");

                        Console.WriteLine("1. Matematika");
                        Console.WriteLine("2. Anglictina");
                        Console.WriteLine("3. Programovani");
                        Console.WriteLine("4. Psychologie");
                        Console.WriteLine("5. Ekonomie");


                        int k1 = Convert.ToInt32(Console.ReadLine());

                        switch (k1)
                        {

                            case 1:
                                int o1 = 0;
                                while (o1 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(o1 + 1);
                                    Console.Write(".");
                                    Console.Write("      ");


                                    Console.Write(studenti[o1]);
                                    Console.Write("       ");
                                    Console.Write(matematika[o1]);

                                    Console.WriteLine("   ");


                                    o1++;
                                }

                                Console.WriteLine("Jakemu studentu chcete znamku odstranit?");
                                Console.WriteLine("   ");

                                int b1 = Convert.ToInt32(Console.ReadLine());
                                b1 = b1 - 1;

                                matematika.Insert(b1, 0);


                                break;

                            case 2:

                                int o2 = 0;
                                while (o2 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(o2 + 1);
                                    Console.Write(".");
                                    Console.Write("      ");


                                    Console.Write(studenti[o2]);
                                    Console.Write("       ");
                                    Console.Write(anglictina[o2]);

                                    Console.WriteLine("   ");


                                    o2++;
                                }

                                Console.WriteLine("Jakemu studentu chcete znamku odstranit?");
                                Console.WriteLine("   ");

                                int b2 = Convert.ToInt32(Console.ReadLine());
                                b2 = b2 - 1;

                                anglictina.Insert(b2, 0);

                                break;

                            case 3:
                                int o3 = 0;
                                while (o3 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(o3 + 1);
                                    Console.Write(".");
                                    Console.Write("      ");


                                    Console.Write(studenti[o3]);
                                    Console.Write("       ");
                                    Console.Write(programovani[o3]);

                                    Console.WriteLine("   ");


                                    o3++;
                                }

                                Console.WriteLine("Jakemu studentu chcete znamku odstranit?");
                                Console.WriteLine("   ");

                                int b3 = Convert.ToInt32(Console.ReadLine());
                                b3 = b3 - 1;

                                programovani.Insert(b3, 0);
                                break;

                            case 4:
                                int o4 = 0;
                                while (o4 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(o4 + 1);
                                    Console.Write(".");
                                    Console.Write("      ");


                                    Console.Write(studenti[o4]);
                                    Console.Write("       ");
                                    Console.Write(psychologie[o4]);

                                    Console.WriteLine("   ");


                                    o4++;
                                }

                                Console.WriteLine("Jakemu studentu chcete znamku odstranit?");
                                Console.WriteLine("   ");

                                int b4 = Convert.ToInt32(Console.ReadLine());
                                b4 = b4 - 1;

                                psychologie.Insert(b4, 0);
                                break;

                            case 5:
                                int o5 = 0;
                                while (o5 != (studenti.Count))
                                {
                                    Console.WriteLine("   ");
                                    Console.Write(o5 + 1);
                                    Console.Write(".");
                                    Console.Write("      ");


                                    Console.Write(studenti[o5]);
                                    Console.Write("       ");
                                    Console.Write(ekonomie[o5]);

                                    Console.WriteLine("   ");


                                    o5++;
                                }

                                Console.WriteLine("Jakemu studentu chcete znamku odstranit?");
                                Console.WriteLine("   ");

                                int b5 = Convert.ToInt32(Console.ReadLine());
                                b5 = b5 - 1;

                                ekonomie.Insert(b5, 0);
                                break;



                            default: Console.WriteLine("Zadejte  jednu z moznosti 1-5 !"); break;


                        }





                        break;






                    case 7:
                        Console.Clear();

                        Console.WriteLine("Vypis XML:  ");

                        String URLString = "E:\\Studenti.xml";
                        XmlTextReader reader = new XmlTextReader(URLString);

                        while (reader.Read())
                        {
                            switch (reader.NodeType)
                            {
                                case XmlNodeType.Element: // The node is an element.
                                    Console.WriteLine("   ");
                                    Console.Write(reader.Name + "  ");

                                    while (reader.MoveToNextAttribute()) // Read the attributes.
                                        Console.WriteLine(" " + reader.Name + "=" + reader.Value);

                                    break;


                            }
                        }




                        Console.WriteLine("===============================================");


                        break;

                    case 8:

                        Console.WriteLine("Ulozeni daty do XML");

                        XmlWriterSettings settings = new XmlWriterSettings();
                        settings.Indent = true;



                        int puk = 0;
                        using (XmlWriter xw = XmlWriter.Create(@"E:\\Studenti.xml", settings))
                        {

                            xw.WriteStartDocument();
                            xw.WriteStartElement("Znamky");



                            while (puk < studenti.Count)
                            {
                                xw.WriteStartElement("MATEMATIKA");
                                xw.WriteAttributeString(studenti[puk], Convert.ToString(matematika[puk]));
                                puk++;
                                xw.WriteEndElement();
                            }
                            puk = 0;
                            while (puk < studenti.Count)
                            {

                                xw.WriteStartElement("ANGLICTINA");
                                xw.WriteAttributeString(studenti[puk], Convert.ToString(anglictina[puk]));
                                puk++;
                                xw.WriteEndElement();
                            }
                            puk = 0;
                            while (puk < studenti.Count)
                            {
                                xw.WriteStartElement("PROGRAMOVANI");
                                xw.WriteAttributeString(studenti[puk], Convert.ToString(programovani[puk]));
                                puk++;
                                xw.WriteEndElement();
                            }
                            puk = 0;
                            while (puk < studenti.Count)
                            {
                                xw.WriteStartElement("PSYCHOLOGIE");
                                xw.WriteAttributeString(studenti[puk], Convert.ToString(psychologie[puk]));
                                puk++;
                                xw.WriteEndElement();
                            }
                            puk = 0;
                            while (puk < studenti.Count)
                            {
                                xw.WriteStartElement("EKONOMIE");
                                xw.WriteAttributeString(studenti[puk], Convert.ToString(ekonomie[puk]));
                                puk++;
                                xw.WriteEndElement();
                            }


                            xw.WriteEndElement();
                            xw.WriteEndDocument();
                            xw.Flush();

                            xw.Close();

                        }



                        Console.WriteLine("Ulozeni probehlo uspesne!");


                        break;



                    default: Console.WriteLine("Zadejte  jednu z moznosi 1-8 !"); break;


                }
            }

            Console.WriteLine("Hodnota odpoved: {0}", odpoved);


        }
    }
}