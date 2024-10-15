// Decompiled with JetBrains decompiler
// Type: SRPG.GlobalEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F6E")]
  public class GlobalEvent
  {
    [Token(Token = "0x400351E")]
    [FieldOffset(Offset = "0x0")]
    private static Dictionary<string, GlobalEvent.Delegate> mListeners;

    [Token(Token = "0x6004029")]
    [Address(RVA = "0x118EAD0", Offset = "0x118D8D0", VA = "0x1118EAD0")]
    public static void AddListener(string eventName, GlobalEvent.Delegate callback)
    {
    }

    [Token(Token = "0x600402A")]
    [Address(RVA = "0x118ECC0", Offset = "0x118DAC0", VA = "0x1118ECC0")]
    public static void RemoveListener(string eventName, GlobalEvent.Delegate callback)
    {
    }

    [Token(Token = "0x600402B")]
    [Address(RVA = "0x118EC00", Offset = "0x118DA00", VA = "0x1118EC00")]
    public static void Invoke(string eventName, object param)
    {
    }

    [Token(Token = "0x600402C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GlobalEvent()
    {
    }

    [Token(Token = "0x600402D")]
    [Address(RVA = "0x118EE30", Offset = "0x118DC30", VA = "0x1118EE30")]
    static GlobalEvent()
    {
    }

    [Token(Token = "0x2000F6F")]
    public delegate void Delegate(object caller);
  }
}
