// Decompiled with JetBrains decompiler
// Type: SRPG.TokkouParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E80")]
  [MessagePackObject(true)]
  [Serializable]
  public class TokkouParam
  {
    [Token(Token = "0x4007E95")]
    [FieldOffset(Offset = "0x8")]
    public List<TokkouValue> values;

    [Token(Token = "0x17001179")]
    public int Count
    {
      [Token(Token = "0x6007D12"), Address(RVA = "0x3F0CC0", Offset = "0x3EFAC0", VA = "0x103F0CC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700117A")]
    [IgnoreMember]
    public TokkouValue this[int index]
    {
      [Token(Token = "0x6007D13"), Address(RVA = "0x3F0D00", Offset = "0x3EFB00", VA = "0x103F0D00")] get
      {
        return (TokkouValue) null;
      }
      [Token(Token = "0x6007D14"), Address(RVA = "0x3F0D50", Offset = "0x3EFB50", VA = "0x103F0D50")] set
      {
      }
    }

    [Token(Token = "0x6007D15")]
    [Address(RVA = "0x3F0A30", Offset = "0x3EF830", VA = "0x103F0A30")]
    public TokkouValue SearchTagMax(string tag) => (TokkouValue) null;

    [Token(Token = "0x6007D16")]
    [Address(RVA = "0x3F06C0", Offset = "0x3EF4C0", VA = "0x103F06C0")]
    public TokkouValue Find(OString new_tag) => (TokkouValue) null;

    [Token(Token = "0x6007D17")]
    [Address(RVA = "0x3F06E0", Offset = "0x3EF4E0", VA = "0x103F06E0")]
    public TokkouValue Find(string new_tag) => (TokkouValue) null;

    [Token(Token = "0x6007D18")]
    [Address(RVA = "0x3F03A0", Offset = "0x3EF1A0", VA = "0x103F03A0")]
    public void Add(TokkouParam param)
    {
    }

    [Token(Token = "0x6007D19")]
    [Address(RVA = "0x3F0B30", Offset = "0x3EF930", VA = "0x103F0B30")]
    public void SubRateRoundDown(long percent)
    {
    }

    [Token(Token = "0x6007D1A")]
    [Address(RVA = "0x3F07B0", Offset = "0x3EF5B0", VA = "0x103F07B0")]
    public void ReplceHighest(TokkouParam param)
    {
    }

    [Token(Token = "0x6007D1B")]
    [Address(RVA = "0x3F08F0", Offset = "0x3EF6F0", VA = "0x103F08F0")]
    public void ReplceLowest(TokkouParam param)
    {
    }

    [Token(Token = "0x6007D1C")]
    [Address(RVA = "0x3F0340", Offset = "0x3EF140", VA = "0x103F0340")]
    public void Add(TokkouValue value)
    {
    }

    [Token(Token = "0x6007D1D")]
    [Address(RVA = "0x3F04D0", Offset = "0x3EF2D0", VA = "0x103F04D0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007D1E")]
    [Address(RVA = "0x3F0530", Offset = "0x3EF330", VA = "0x103F0530")]
    public void CopyTo(TokkouParam dsc)
    {
    }

    [Token(Token = "0x6007D1F")]
    [Address(RVA = "0x3F0C50", Offset = "0x3EFA50", VA = "0x103F0C50")]
    public TokkouParam()
    {
    }
  }
}
