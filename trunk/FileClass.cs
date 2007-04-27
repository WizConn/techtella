using System.Collections;
using System.IO;
using System.Text;
using System;

namespace Techtella
{
    public class FileClass
    {
        private static ArrayList FileList;
        private static ArrayList FileIDs;
        private static ArrayList NetFiles;
        private static ArrayList FileHosts;
        private static ArrayList FileCodes;

        public FileClass()
        {
            FileList = new ArrayList();
            FileIDs = new ArrayList();
            NetFiles = new ArrayList();
            FileCodes = new ArrayList();
            FileHosts = new ArrayList();
        }

        public static int AddFile(string filename)
        {
            if (FileList != null)
            {
                foreach (object fileObj in FileList)
                {
                    if (fileObj.ToString() == filename)
                    {
                        return 0;
                    }
                }
            }
            FileList.Add(filename);
            FileIDs.Add(filename.GetHashCode());
            return 1;
        }

        public static int RemoveFile(string filename)
        {
            object toRemove = null;
            if (FileList != null)
            {
                foreach (object fileObj in FileList)
                {
                    if (fileObj.ToString().Split('*')[2].Split('\\')[fileObj.ToString().Split('*')[2].Split('\\').Length-1].Split('|')[0] == filename)
                    {
                        toRemove = fileObj;
                    }
                }
                if (toRemove != null)
                {
                    FileList.Remove(toRemove);
                    FileIDs.Remove(toRemove.ToString().GetHashCode());
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public static int RemoveNetFile(string filename)
        {
            object toRemove = null;
            if (NetFiles != null)
            {
                foreach (object fileObj in NetFiles)
                {
                    if (fileObj.ToString().Split('*')[2].Split('\\')[fileObj.ToString().Split('*')[2].Split('\\').Length-1].Split('|')[0] == filename)
                    {
                        toRemove = fileObj;
                    }
                }
                if (toRemove != null)
                {
                    FileCodes.Remove(FileCodes.ToArray()[NetFiles.IndexOf(toRemove)-1]);
                    FileHosts.Remove(FileHosts.ToArray()[NetFiles.IndexOf(toRemove)-1]);
                    NetFiles.Remove(toRemove);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public static int AddNetFile(string filename, int code, string host)
        {
            Console.WriteLine("AddNetFile called: " + filename + " " + code + " " + host);
            if (NetFiles != null)
            {
                foreach (object fileObj in NetFiles)
                {
                    if (fileObj.ToString() == filename)
                    {
                        Console.WriteLine("I already have this file: " + fileObj.ToString());
                        return 0;
                    }
                }
            }
            NetFiles.Add(filename);
            FileCodes.Add(code);
            FileHosts.Add(host);
            Console.WriteLine(filename + " added to NetFiles from " + host + " with download code " + code);
            return 1;
        }

        public static ArrayList GetFileData()
        {
            return FileList;
        }

        public static ArrayList GetFileIDs()
        {
            return FileIDs;
        }

        public static ArrayList GetNetFiles()
        {
            return NetFiles;
        }

        public static ArrayList GetDownCodes()
        {
            return FileCodes;
        }

        public static ArrayList GetHosts()
        {
            return FileHosts;
        }

        public static int HasFile(string criteria)
        {
            Console.WriteLine("Checking for " + criteria);
            foreach (object File in FileList)
            {
                Console.WriteLine(File.ToString());
                Console.WriteLine(File.ToString().Split('*')[0] + " ?= " + criteria.Split('*')[0].Split('|'));
                if (File.ToString().Split('*')[0] == criteria.Split('*')[0].Split('|')[0] || criteria.ToString().Split('*')[0] == "ANY")
                {
                    Console.WriteLine(File.ToString().Split('*')[1].Split('|')[0] + " ?= " + criteria.Split('*')[1].Split('|'));
                    if (File.ToString().Split('*')[1].Split('|')[0] == criteria.Split('*')[1].Split('|')[0])
                    {
                        return 1;
                    }
                    Console.WriteLine(File.ToString().Split('*')[2].Split('|')[0] + " ?= " + criteria.Split('*')[2].Split('\\')[criteria.Split('*')[2].Split('\\').Length-1].Split('|')[0]);
                    if (File.ToString().Split('*')[2].Split('\\')[File.ToString().Split('*')[2].Split('\\').Length-1].Split('|')[0] == criteria.Split('*')[2].Split('\\')[criteria.Split('*')[2].Split('\\').Length-1].Split('|')[0])
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }

        public static string CorrectFileName(string criteria)
        {
            Console.WriteLine("Correcting " + criteria);
            foreach (object File in FileList)
            {
                if (File.ToString().Split('*')[0] == criteria.Split('*')[0] || File.ToString().Split('*')[0] == "ANY")
                {
                    if (File.ToString().Split('*')[1].Split('|')[0] == criteria.Split('*')[1].Split('|')[0])
                    {
                        Console.WriteLine(File.ToString().Split('*')[2].Split('\\')[File.ToString().Split('*')[2].Split('\\').Length - 1]);
                        return File.ToString().Split('*')[2].Split('\\')[File.ToString().Split('*')[2].Split('\\').Length - 1];
                    }
                    if (File.ToString().Split('*')[2].Split('\\')[File.ToString().Split('*')[2].Split('\\').Length - 1].Split('|')[0] == criteria.Split('*')[2].Split('\\')[criteria.Split('*')[2].Split('\\').Length - 1].Split('|')[0])
                    {
                        Console.WriteLine(File.ToString().Split('*')[2].Split('\\')[File.ToString().Split('*')[2].Split('\\').Length-1]);
                        return File.ToString().Split('*')[2].Split('\\')[File.ToString().Split('*')[2].Split('\\').Length-1];
                    }
                }
            }
            Console.WriteLine("Um... couldn't... correct... filename?... wtf?");
            return "OMFG!";
        }

        public static string GetFilePath(string criteria)
        {
            Console.WriteLine("GetFilePath called for " + criteria);
            foreach (object File in FileList)
            {
                Console.WriteLine(File.ToString().Split('*')[2].Split('|')[0].Split('\\')[File.ToString().Split('*')[2].Split('\\').Length - 1]);
                    if (File.ToString().Split('*')[2].Split('|')[0].Split('\\')[File.ToString().Split('*')[2].Split('\\').Length-1] == criteria)
                    {
                        Console.WriteLine("Getting filepath");
                        string[] parts = File.ToString().Split('*')[2].Split('\\');
                        string path = "";
                        foreach (string part in parts)
                        {
                            if (part.Split('|')[0] != criteria)
                            {
                                path += part + @"\";
                            }
                        }
                        Console.WriteLine(path);
                        return path;
                    }
            }
            Console.WriteLine("Um... couldn't... get... filepath?... wtf?");
            return "OMFG!";
        }
    }
}