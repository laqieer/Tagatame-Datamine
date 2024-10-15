// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.AuthDummyWebTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Gsc.Tasks;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x2003654")]
  public class AuthDummyWebTask : IWebTask, IWebTaskBase, ITask, IEnumerator
  {
    [Token(Token = "0x170022F9")]
    public WebTaskResult Result
    {
      [Token(Token = "0x600F2DA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0", Slot = "5")] get
      {
        return new WebTaskResult();
      }
      [Token(Token = "0x600F2DB"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x170022FA")]
    public byte[] error
    {
      [Token(Token = "0x600F2DC"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "6")] get
      {
        return (byte[]) null;
      }
    }

    [Token(Token = "0x170022FB")]
    public bool handled
    {
      [Token(Token = "0x600F2DD"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170022FC")]
    public bool isDone
    {
      [Token(Token = "0x600F2DE"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170022FD")]
    public bool isBreak
    {
      [Token(Token = "0x600F2DF"), Address(RVA = "0xB1FB10", Offset = "0xB1E910", VA = "0x10B1FB10", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170022FE")]
    public object Current
    {
      [Token(Token = "0x600F2E0"), Address(RVA = "0xB1FAD0", Offset = "0xB1E8D0", VA = "0x10B1FAD0", Slot = "19")] get
      {
        return (object) null;
      }
    }

    [Token(Token = "0x600F2E1")]
    [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
    public AuthDummyWebTask(WebTaskResult result)
    {
    }

    [Token(Token = "0x600F2E2")]
    [Address(RVA = "0xB1FA50", Offset = "0xB1E850", VA = "0x10B1FA50", Slot = "7")]
    public void Retry()
    {
    }

    [Token(Token = "0x600F2E3")]
    [Address(RVA = "0xB1F810", Offset = "0xB1E610", VA = "0x10B1F810", Slot = "13")]
    public void Break()
    {
    }

    [Token(Token = "0x600F2E4")]
    [Address(RVA = "0xB1F910", Offset = "0xB1E710", VA = "0x10B1F910", Slot = "8")]
    public bool IsAcceptResult(WebTaskResult result) => new bool();

    [Token(Token = "0x600F2E5")]
    [Address(RVA = "0xB1F8D0", Offset = "0xB1E6D0", VA = "0x10B1F8D0", Slot = "9")]
    public bool HasAttributes(WebTaskAttribute attributes) => new bool();

    [Token(Token = "0x600F2E6")]
    [Address(RVA = "0xB1F850", Offset = "0xB1E650", VA = "0x10B1F850", Slot = "10")]
    public WebInternalTask GetInternalTask() => (WebInternalTask) null;

    [Token(Token = "0x600F2E7")]
    [Address(RVA = "0xB1F890", Offset = "0xB1E690", VA = "0x10B1F890", Slot = "11")]
    public Type GetRequestType() => (Type) null;

    [Token(Token = "0x600F2E8")]
    [Address(RVA = "0xB1F9D0", Offset = "0xB1E7D0", VA = "0x10B1F9D0", Slot = "15")]
    public void OnStart()
    {
    }

    [Token(Token = "0x600F2E9")]
    [Address(RVA = "0xB1FA90", Offset = "0xB1E890", VA = "0x10B1FA90", Slot = "16")]
    public IEnumerator Run() => (IEnumerator) null;

    [Token(Token = "0x600F2EA")]
    [Address(RVA = "0xB1F990", Offset = "0xB1E790", VA = "0x10B1F990", Slot = "17")]
    public void OnFinish()
    {
    }

    [Token(Token = "0x600F2EB")]
    [Address(RVA = "0xB1FA10", Offset = "0xB1E810", VA = "0x10B1FA10", Slot = "20")]
    public void Reset()
    {
    }

    [Token(Token = "0x600F2EC")]
    [Address(RVA = "0xB1F950", Offset = "0xB1E750", VA = "0x10B1F950", Slot = "18")]
    public bool MoveNext() => new bool();
  }
}
