using System.Collections;

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
                    if (fileObj.ToString().Split('*')[1] == filename)
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
                    if (fileObj.ToString().Split('*')[1] == filename)
                    {
                        toRemove = fileObj;
                    }
                }
                if (toRemove != null)
                {
                    FileCodes.Remove(FileCodes.ToArray()[NetFiles.IndexOf(toRemove)]);
                    FileHosts.Remove(FileHosts.ToArray()[NetFiles.IndexOf(toRemove)]);
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
            NetFiles.Add(code);
            FileHosts.Add(host);
            return 1;
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

    }
}