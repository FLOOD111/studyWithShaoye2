using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWS.Core
{
    #region 题目一
    interface IRegister
    {
        void Register();
    }

    public class Person : IRegister
    {
        public void Register()
        {

        }
    }
    #endregion

    #region 题目二
    interface IFly
    {
        void Fly();
    }
    interface ISwim
    {
        void Swim();
    }
    public abstract class Bird
    {
        public abstract void Walk();
    }

    public class MaQue : Bird, IFly
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
    public class TuoNiao : Bird
    {
        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
    public class QiE : Bird, ISwim
    {
        public void Swim()
        {
            throw new NotImplementedException();
        }

        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
    public class YingWu : Bird, IFly
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
    public class ZhiShengJi : IFly
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
    public class TianE : Bird, ISwim
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region 题目三
    public interface IUSB
    {
        void TransferData();
    }
    public class Computer
    {
        public IUSB? uSB;
    }
    public class StorageDivice : IUSB
    {
        public string name;
        public void TransferData()
        {
            Console.WriteLine(name + "传输数据");
        }

        public StorageDivice(string name)
        {
            this.name = name;
        }
    }
    public class MP3 : IUSB
    {
        public void PlayBack()
        {
            Console.WriteLine("播放");
        }
        public void TransferData()
        {
            Console.WriteLine("MP3 传输数据");
        }
    }
    #endregion
}
