using System;
using System.IO;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository
    {
        private int id;
        private DirectoryInfo repositoryDir;

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public long NextId()
        {
            id++;
            return id;
        }
    }
}