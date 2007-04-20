using System.Collections;

namespace Techtella
{
    public class FileClass
    {
        private static ArrayList FileList;
        private static ArrayList FileIDs;
        private static ArrayList NetFiles;

        public FileClass()
        {
            FileList = new ArrayList();
            FileIDs = new ArrayList();
            NetFiles = new ArrayList();
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

        public static int AddNetFile(string filename)
        {
            if (NetFiles != null)
            {
                foreach (object fileObj in NetFiles)
                {
                    if (fileObj.ToString() == filename)
                    {
                        return 0;
                    }
                }
            }
            NetFiles.Add(filename);
        }

        public static int GetFileByTitle(string search)
        {
            int index = 0;
            if (FileList != null)
            {
                foreach (object fileObj in FileList)
                {
                    if (fileObj.ToString().Split('*')[1] == search)
                    {
                        return (int)FileIDs.ToArray()[index];
                    }
                    index++;
                }
            }
            return 0;
        }

        public static string GetFileByHash(int hash)
        {
            int index = 0;
            if (FileIDs != null)
            {
                foreach (object fileObj in FileIDs)
                {
                    if ((int)fileObj == hash)
                    {
                        return (string)FileList.ToArray()[index];
                    }
                    index++;
                }
            }
            return "none";
        }

        public ArrayList GetFileData()
        {
            return FileList;
        }

        public ArrayList GetFileIDs()
        {
            return FileIDs;
        }

        public ArrayList GetNetFiles()
        {
            return NetFiles;
        }

    }
}