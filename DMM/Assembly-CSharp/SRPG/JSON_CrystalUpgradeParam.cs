// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalUpgradeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AA7")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalUpgradeParam
  {
    [Token(Token = "0x40062C8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40062C9")]
    [FieldOffset(Offset = "0xC")]
    public string next_iname;
    [Token(Token = "0x40062CA")]
    [FieldOffset(Offset = "0x10")]
    public int rank;
    [Token(Token = "0x40062CB")]
    [FieldOffset(Offset = "0x14")]
    public int mat_num;

    [Token(Token = "0x6006DE6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalUpgradeParam()
    {
    }
  }
}
