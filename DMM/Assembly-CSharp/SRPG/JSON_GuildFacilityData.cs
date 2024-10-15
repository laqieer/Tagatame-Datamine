// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F94")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildFacilityData
  {
    [Token(Token = "0x40036D7")]
    [FieldOffset(Offset = "0x8")]
    public long gid;
    [Token(Token = "0x40036D8")]
    [FieldOffset(Offset = "0x10")]
    public string facility_iname;
    [Token(Token = "0x40036D9")]
    [FieldOffset(Offset = "0x18")]
    public long exp;
    [Token(Token = "0x40036DA")]
    [FieldOffset(Offset = "0x20")]
    public int level;
    [Token(Token = "0x40036DB")]
    [FieldOffset(Offset = "0x24")]
    public int invest_point;

    [Token(Token = "0x60040B2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildFacilityData()
    {
    }
  }
}
