// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalRecommendCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A8E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalRecommendCondParam
  {
    [Token(Token = "0x4006253")]
    [FieldOffset(Offset = "0x8")]
    public string cnds_iname;
    [Token(Token = "0x4006254")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4006255")]
    [FieldOffset(Offset = "0x10")]
    public int param_type;
    [Token(Token = "0x4006256")]
    [FieldOffset(Offset = "0x14")]
    public string tag_name;

    [Token(Token = "0x6006D39")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalRecommendCondParam()
    {
    }
  }
}
