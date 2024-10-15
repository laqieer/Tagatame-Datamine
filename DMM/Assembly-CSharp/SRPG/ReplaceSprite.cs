// Decompiled with JetBrains decompiler
// Type: SRPG.ReplaceSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002671")]
  [MessagePackObject(true)]
  public class ReplaceSprite
  {
    [Token(Token = "0x400B3A4")]
    [FieldOffset(Offset = "0x8")]
    public string mIname;
    [Token(Token = "0x400B3A5")]
    [FieldOffset(Offset = "0xC")]
    public List<ReplacePeriod> mPeriod;

    [Token(Token = "0x600AB9D")]
    [Address(RVA = "0x6F1860", Offset = "0x6F0660", VA = "0x106F1860")]
    public static void Deserialize(ref List<ReplaceSprite> ref_params, JSON_ReplaceSprite[] json)
    {
    }

    [Token(Token = "0x600AB9E")]
    [Address(RVA = "0x6F1B00", Offset = "0x6F0900", VA = "0x106F1B00")]
    public void Deserialize(JSON_ReplaceSprite json)
    {
    }

    [Token(Token = "0x600AB9F")]
    [Address(RVA = "0x6F1C20", Offset = "0x6F0A20", VA = "0x106F1C20")]
    public ReplaceSprite()
    {
    }
  }
}
