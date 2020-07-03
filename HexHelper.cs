using System;
using System.Collections.Generic;

namespace CODEVEINStatChanger
{
    public class HexHelper
    {


        //S 53 00 72 CA D9 7E
        //A 41 00 6C 2A CD E1
        //B 42 00 B5 0C 23 4E
        //C 43 00 02 11 46 29
        //D 44 00 07 41 FF 11
        //E 45 00 B0 5C 9A 76

        //S_Plus 53 5F 50 6C 75 73 00 BE BD C2 1B
        //A_Plus 41 5F 50 6C 75 73 00 EC A1 F0 A8
        //B_Plus 42 5F 50 6C 75 73 00 F2 F4 D8 01
        //C_Plus 43 5F 50 6C 75 73 00 0C E5 FF 64
        //D_Plus 44 5F 50 6C 75 73 00 DB 52 88 53
        //E_Plus 45 5F 50 6C 75 73 00 25 43 AF 36


        public static Dictionary<String, Byte[]> RankDataDictionary = new Dictionary<string, byte[]>();

        //ECharacterAttributeRank::
        public static readonly byte[] ECharacterAttributeRankData = { 0x45, 0x43, 0x68, 0x61, 0x72, 0x61, 0x63, 0x74, 0x65, 0x72, 0x41, 0x74, 0x74, 0x72, 0x69, 0x62, 0x75, 0x74, 0x65, 0x52, 0x61, 0x6E, 0x6B, 0x3A, 0x3A };

        public List<DataOffset> DataOffsets;

        private byte[] Data;


        public struct DataOffset
        {

            public long Index;
            public String Type;


        }

        static HexHelper()
        {
            byte[] S = { 0x53, 0x00, 0x72, 0xCA, 0xD9, 0x7E };
            byte[] A = { 0x41, 0x00, 0x6C, 0x2A, 0xCD, 0xE1 };
            byte[] B = { 0x42, 0x00, 0xB5, 0x0C, 0x23, 0x4E };
            byte[] C = { 0x43, 0x00, 0x02, 0x11, 0x46, 0x29 };
            byte[] D = { 0x44, 0x00, 0x07, 0x41, 0xFF, 0x11 };
            byte[] E = { 0x45, 0x00, 0xB0, 0x5C, 0x9A, 0x76 };

            byte[] S_Plus = { 0x53, 0x5F, 0x50, 0x6C, 0x75, 0x73, 0x00, 0xBE, 0xBD, 0xC2, 0x1B };
            byte[] A_Plus = { 0x41, 0x5F, 0x50, 0x6C, 0x75, 0x73, 0x00, 0xEC, 0xA1, 0xF0, 0xA8 };
            byte[] B_Plus = { 0x42, 0x5F, 0x50, 0x6C, 0x75, 0x73, 0x00, 0xF2, 0xF4, 0xD8, 0x01 };
            byte[] C_Plus = { 0x43, 0x5F, 0x50, 0x6C, 0x75, 0x73, 0x00, 0x0C, 0xE5, 0xFF, 0x64 };
            byte[] D_Plus = { 0x44, 0x5F, 0x50, 0x6C, 0x75, 0x73, 0x00, 0xDB, 0x52, 0x88, 0x53 };
            byte[] E_Plus = { 0x45, 0x5F, 0x50, 0x6C, 0x75, 0x73, 0x00, 0x25, 0x43, 0xAF, 0x36 };


            RankDataDictionary.Add("S_Plus", S_Plus);
            RankDataDictionary.Add("A_Plus", A_Plus);
            RankDataDictionary.Add("B_Plus", B_Plus);
            RankDataDictionary.Add("C_Plus", C_Plus);
            RankDataDictionary.Add("D_Plus", D_Plus);
            RankDataDictionary.Add("E_Plus", E_Plus);

            RankDataDictionary.Add("S", S);
            RankDataDictionary.Add("A", A);
            RankDataDictionary.Add("B", B);
            RankDataDictionary.Add("C", C);
            RankDataDictionary.Add("D", D);
            RankDataDictionary.Add("E", E);


        }


        private HexHelper() { }

        public HexHelper(byte[] data)
        {

            this.Data = data;
            DataOffsets = new List<DataOffset>();

            GetIndex();


        }

        private void GetIndex()
        {

            long cursor = 0;

            while (cursor < Data.Length)
            {


                if (Data[cursor] == ECharacterAttributeRankData[0])
                {

                    System.Console.WriteLine("Found Possibile ECharacterAttributeRank:: At:{0:x}", cursor);
                    GetIndexTask(ref cursor);
                }



                cursor++;
            }



        }


        public byte[] SaveIndex()
        {



            foreach(var i in DataOffsets)
            {

                byte[] data = RankDataDictionary[i.Type];


                for(int offset = 0; offset < data.Length; offset++)
                {

                    System.Console.WriteLine("Writing ECharacterAttributeRank:: At:{0:x} Target:{1:x} Original:{2:x}", i.Index+offset, data[offset], Data[i.Index+offset]);

                    Data[i.Index + offset] = data[offset];



                }




            }

            return this.Data;


        }

        private void GetIndexTask(ref long cursor)
        {

            long current = cursor;

            for (int i = 0; i < ECharacterAttributeRankData.Length; i++)
            {

                if (Data[cursor] != ECharacterAttributeRankData[i])
                {
                    System.Console.WriteLine("Not ECharacterAttributeRank:: At:{0:x} Value:{1:x} Plan:{2:x}", cursor, Data[cursor], ECharacterAttributeRankData[i]);
                    return;
                }
                else
                {
                    System.Console.WriteLine("Check ECharacterAttributeRank:: At:{0:x} Value:{1:x} Plan:{2:x}", cursor, Data[cursor], ECharacterAttributeRankData[i]);
                    //Console.Write("{0:x}",Data[cursor]);
                }
                cursor++;
            }



            System.Console.WriteLine("Found ECharacterAttributeRank:: At:{0:x} End:{1:x}", current, cursor);
            

            //cursor++;

            System.Console.WriteLine("Check Rank At:{0:x}",cursor);

            foreach (var item in RankDataDictionary)
            {
                System.Console.WriteLine("Check {0}!", item.Key);

                bool flag = false;
                for (int i = 0; i < item.Value.Length; i++)
                {
                    
                    if (Data[cursor + i] != item.Value[i])
                    {
                        System.Console.WriteLine("Not is {0}! At:{0:x} Value:{1:x} Plan:{2:x}", item.Key,cursor+i,Data[cursor+i],item.Value[i]);
                        
                        break;
                    }
                    else
                    {

                        if(i== item.Value.Length - 1)
                        {
                            flag = true;
                        }


                    }

                    if (flag)
                    {
                        System.Console.WriteLine("is {0}!", item.Key);

                        DataOffset data;
                        data.Index = cursor;
                        data.Type = item.Key;

                        DataOffsets.Add(data);


                        cursor += i;
                        return;
                    }



                }


            }

        }






    }
}
