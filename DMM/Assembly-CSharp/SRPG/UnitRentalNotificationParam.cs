// Decompiled with JetBrains decompiler
// Type: SRPG.UnitRentalNotificationParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E97")]
  public class UnitRentalNotificationParam
  {
    [Token(Token = "0x4007FD7")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4007FD8")]
    [FieldOffset(Offset = "0xC")]
    private UnitRentalNotificationDataParam[] mNotiInfos;

    [Token(Token = "0x17001188")]
    public string Iname
    {
      [Token(Token = "0x6007D76"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001189")]
    public List<UnitRentalNotificationDataParam> NotiList
    {
      [Token(Token = "0x6007D77"), Address(RVA = "0x3F5910", Offset = "0x3F4710", VA = "0x103F5910")] get
      {
        return (List<UnitRentalNotificationDataParam>) null;
      }
    }

    [Token(Token = "0x6007D78")]
    [Address(RVA = "0x3F5520", Offset = "0x3F4320", VA = "0x103F5520")]
    public void Deserialize(JSON_UnitRentalNotificationParam json)
    {
    }

    [Token(Token = "0x6007D79")]
    [Address(RVA = "0x3F53B0", Offset = "0x3F41B0", VA = "0x103F53B0")]
    public static void Deserialize(
      ref Dictionary<string, UnitRentalNotificationParam> dict,
      JSON_UnitRentalNotificationParam[] json)
    {
    }

    [Token(Token = "0x6007D7A")]
    [Address(RVA = "0x3F5740", Offset = "0x3F4540", VA = "0x103F5740")]
    public static UnitRentalNotificationParam GetParam(string key)
    {
      return (UnitRentalNotificationParam) null;
    }

    [Token(Token = "0x6007D7B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitRentalNotificationParam()
    {
    }
  }
}
