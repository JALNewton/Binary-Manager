using System;
using System.IO;

namespace src
{
    public  class BinaryManager
    {
        private  BinaryReader BinReader;
        private  BinaryWriter BinWriter;

        public  void ReadLoadFile(string namefile_or_location)
        {
            BinReader = new BinaryReader(File.Open(namefile_or_location, FileMode.Open));
        }

        public  void WriteLoadFile(string namefile_or_location)
        {
            BinWriter = new BinaryWriter(File.Open(namefile_or_location, FileMode.OpenOrCreate));
        }

        public  void Write(int value_)
        {
            if(BinWriter != null)
                BinWriter.Write(value_);
        }

        public  void Write(short value_)
        {
            if(BinWriter != null)
                BinWriter.Write(value_);
        }

        public  void Write(string value_)
        {
            if(BinWriter != null)            
                BinWriter.Write(value_);            
        }

        public  void Write(byte value_)
        {
            if(BinWriter != null)
                BinWriter.Write(value_);
        }

        public  void Write(byte[] value_)
        {
            if(BinWriter != null)
                BinWriter.Write(value_);
        }

        public  void Write(ushort value_)
        {
            if(BinWriter != null)
                BinWriter.Write(value_);
        }

        public  void Write(uint value_)
        {
            if(BinWriter != null)
                BinWriter.Write(value_);
        }

        public  void Write(long value_)
        {
            if(BinWriter != null)
                BinWriter.Write(value_);
        }

        public  void Write(ulong value_)
        {
            if(BinWriter != null)
                BinWriter.Write(value_);
        }

        public  int ReadInt32()
        {
            if(BinReader != null)
                return BinReader.ReadInt32();
            return 0;
        }

        public  uint ReadUInt32()
        {
            if(BinReader != null)
                return BinReader.ReadUInt32();
            return 0;
        }

        public  short ReadShort()
        {
            if(BinReader != null)
                return BinReader.ReadInt16();
            return 0;
        }

        public string ReadString()
        {
            if(BinReader != null)
                return BinReader.ReadString();            
            return string.Empty;
        }


        public  ushort ReadUShort()
        {
            if(BinReader != null)
                return BinReader.ReadUInt16();
            return 0;
        }

        public  long ReadLong()
        {
            if(BinReader != null)
                return BinReader.ReadInt64();
            return 0;
        }
        public  ulong ReadULong()
        {
            if(BinReader != null)
                return BinReader.ReadUInt64();
            return 0;
        }

        public  byte ReadByte()
        {
            if(BinReader != null)
                return BinReader.ReadByte();
            return 0;
        }

        public  byte[] ReadBytes(int size_)
        {
            if(BinReader != null)
                return BinReader.ReadBytes(size_);
            return null;
        }

        public  void CloseFileReader()
        {
            if(BinReader != null)
                BinReader.Close();
        }

        public  void CloseFileWriter()
        {
            if(BinWriter != null)
                BinWriter.Close();
        }


        public  void CloseFile()
        {
            if(BinReader != null)
                BinReader.Close();
            if(BinWriter != null)
                BinWriter.Close();
        }

        public  void Close()
        {
            if(BinReader != null)
                BinReader.Close();
            if(BinWriter != null)
                BinWriter.Close();
        }

        public  void SetPosition(int pos_)
        {
            if(BinReader != null)
                BinReader.BaseStream.Position = pos_;
            if(BinWriter != null)
                BinWriter.BaseStream.Position = pos_;
        }

        public  void SetReaderPosition(int pos_)
        {
            if(BinReader != null)
                BinReader.BaseStream.Position = pos_;
        }

         public  void SetWriterPosition(int pos_)
        {
            if(BinWriter != null)
                BinWriter.BaseStream.Position = pos_;
        }
        
    }
}