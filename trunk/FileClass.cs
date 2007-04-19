using System.Collections;

namespace TECHTELLA
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
            foreach (object fileObj in FileList)
            {
                if (fileObj.ToString() == filename)
                {
                    return 0;
                }
            }
            FileList.Add(filename);
            FileIDs.Add(filename.GetHashCode());
            return 1;
        }

        public static int GetFileByName(string search)
        {
            int index = 0;
            foreach (object fileObj in FileList)
            {
                if (fileObj.ToString() == search)
                {
                    return (int)FileIDs.ToArray()[index];
                }
                index++;
            }
            return 0;
        }

        public static string GetFileByHash(int hash)
        {
            int index = 0;
            foreach (object fileObj in FileIDs)
            {
                if ((int)fileObj == hash)
                {
                    return (string)FileList.ToArray()[index];
                }
                index++;
            }
            return "none";
        }

    }
}