// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentReceiveList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AEC")]
  public class FriendPresentReceiveList
  {
    [Token(Token = "0x400661B")]
    [FieldOffset(Offset = "0x8")]
    private List<FriendPresentReceiveList.FriendPresentReceiveParam> m_List;

    [Token(Token = "0x17000CBA")]
    public FriendPresentReceiveList.FriendPresentReceiveParam this[int index]
    {
      [Token(Token = "0x6006F1D"), Address(RVA = "0x368970", Offset = "0x367770", VA = "0x10368970")] get
      {
        return (FriendPresentReceiveList.FriendPresentReceiveParam) null;
      }
    }

    [Token(Token = "0x17000CBB")]
    public int count
    {
      [Token(Token = "0x6006F1E"), Address(RVA = "0x368A10", Offset = "0x367810", VA = "0x10368A10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CBC")]
    public List<FriendPresentReceiveList.FriendPresentReceiveParam> list
    {
      [Token(Token = "0x6006F1F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<FriendPresentReceiveList.FriendPresentReceiveParam>) null;
      }
    }

    [Token(Token = "0x17000CBD")]
    public FriendPresentReceiveList.FriendPresentReceiveParam[] array
    {
      [Token(Token = "0x6006F20"), Address(RVA = "0x3689D0", Offset = "0x3677D0", VA = "0x103689D0")] get
      {
        return (FriendPresentReceiveList.FriendPresentReceiveParam[]) null;
      }
    }

    [Token(Token = "0x6006F21")]
    [Address(RVA = "0x368430", Offset = "0x367230", VA = "0x10368430")]
    public void Clear()
    {
    }

    [Token(Token = "0x6006F22")]
    [Address(RVA = "0x368840", Offset = "0x367640", VA = "0x10368840")]
    public FriendPresentReceiveList.FriendPresentReceiveParam GetFriendPresentReceiveParam(
      string iname)
    {
      return (FriendPresentReceiveList.FriendPresentReceiveParam) null;
    }

    [Token(Token = "0x6006F23")]
    [Address(RVA = "0x368490", Offset = "0x367290", VA = "0x10368490")]
    public void Deserialize(FriendPresentReceiveList.Json[] jsons)
    {
    }

    [Token(Token = "0x6006F24")]
    [Address(RVA = "0x368900", Offset = "0x367700", VA = "0x10368900")]
    public FriendPresentReceiveList()
    {
    }

    [Token(Token = "0x2001AED")]
    [Serializable]
    public class Json
    {
      [Token(Token = "0x400661C")]
      [FieldOffset(Offset = "0x8")]
      public string pname;
      [Token(Token = "0x400661D")]
      [FieldOffset(Offset = "0xC")]
      public int num;
      [Token(Token = "0x400661E")]
      [FieldOffset(Offset = "0x10")]
      public string[] fuids;

      [Token(Token = "0x6006F25")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json()
      {
      }
    }

    [Token(Token = "0x2001AEE")]
    public class FriendPresentReceiveParam
    {
      [Token(Token = "0x400661F")]
      [FieldOffset(Offset = "0x8")]
      public FriendPresentItemParam present;
      [Token(Token = "0x4006620")]
      [FieldOffset(Offset = "0xC")]
      public string iname;
      [Token(Token = "0x4006621")]
      [FieldOffset(Offset = "0x10")]
      public int num;
      [Token(Token = "0x4006622")]
      [FieldOffset(Offset = "0x14")]
      public List<string> uids;

      [Token(Token = "0x6006F26")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public FriendPresentReceiveParam()
      {
      }
    }
  }
}
