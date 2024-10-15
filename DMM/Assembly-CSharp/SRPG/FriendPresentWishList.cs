// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentWishList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AEA")]
  public class FriendPresentWishList
  {
    [Token(Token = "0x4006618")]
    [FieldOffset(Offset = "0x8")]
    private FriendPresentItemParam[] m_Array;

    [Token(Token = "0x17000CB7")]
    public FriendPresentItemParam this[int index]
    {
      [Token(Token = "0x6006F15"), Address(RVA = "0x368DF0", Offset = "0x367BF0", VA = "0x10368DF0")] get
      {
        return (FriendPresentItemParam) null;
      }
    }

    [Token(Token = "0x17000CB8")]
    public int count
    {
      [Token(Token = "0x6006F16"), Address(RVA = "0x368E20", Offset = "0x367C20", VA = "0x10368E20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CB9")]
    public FriendPresentItemParam[] array
    {
      [Token(Token = "0x6006F17"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (FriendPresentItemParam[]) null;
      }
    }

    [Token(Token = "0x6006F18")]
    [Address(RVA = "0x368A50", Offset = "0x367850", VA = "0x10368A50")]
    public void Clear()
    {
    }

    [Token(Token = "0x6006F19")]
    [Address(RVA = "0x368CF0", Offset = "0x367AF0", VA = "0x10368CF0")]
    public void Set(string iname, int priority)
    {
    }

    [Token(Token = "0x6006F1A")]
    [Address(RVA = "0x368AC0", Offset = "0x3678C0", VA = "0x10368AC0")]
    public void Deserialize(FriendPresentWishList.Json[] jsons)
    {
    }

    [Token(Token = "0x6006F1B")]
    [Address(RVA = "0x368DA0", Offset = "0x367BA0", VA = "0x10368DA0")]
    public FriendPresentWishList()
    {
    }

    [Token(Token = "0x2001AEB")]
    [Serializable]
    public class Json
    {
      [Token(Token = "0x4006619")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400661A")]
      [FieldOffset(Offset = "0xC")]
      public int priority;

      [Token(Token = "0x6006F1C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json()
      {
      }
    }
  }
}
