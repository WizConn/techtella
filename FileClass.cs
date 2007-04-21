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

        public int AddFile(string filename)
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

        public int RemoveFile(string filename)
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

        public int RemoveNetFile(string filename)
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

        public int AddNetFile(string filename, int code, string host)
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

        public ArrayList GetDownCodes()
        {
            return FileCodes;
        }

        public ArrayList GetHosts()
        {
            return FileHosts;
        }

        public static int HasFile(string criteria)
        {
            foreach (object File in FileList)
            {
                if (File.ToString().Split('*')[0] == criteria.Split('*')[0])
                {
                    if (File.ToString().Split('*')[1] == criteria.Split('*')[0])
                    {
                        return 1;
                    }
                    if (File.ToString().Split('*')[2] == criteria.Split('*')[2])
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }

    }
}