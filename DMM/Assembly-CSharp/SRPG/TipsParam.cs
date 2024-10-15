// Decompiled with JetBrains decompiler
// Type: SRPG.TipsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D55")]
  public class TipsParam
  {
    [Token(Token = "0x4007379")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400737A")]
    [FieldOffset(Offset = "0xC")]
    public ETipsType type;
    [Token(Token = "0x400737B")]
    [FieldOffset(Offset = "0x10")]
    public int order;
    [Token(Token = "0x400737C")]
    [FieldOffset(Offset = "0x14")]
    public string title;
    [Token(Token = "0x400737D")]
    [FieldOffset(Offset = "0x18")]
    public string text;
    [Token(Token = "0x400737E")]
    [FieldOffset(Offset = "0x1C")]
    public string[] images;
    [Token(Token = "0x400737F")]
    [FieldOffset(Offset = "0x20")]
    public bool hide;
    [Token(Token = "0x4007380")]
    [FieldOffset(Offset = "0x24")]
    public string cond_text;

    [Token(Token = "0x600782A")]
    [Address(RVA = "0x3A3AE0", Offset = "0x3A28E0", VA = "0x103A3AE0")]
    public void Deserialize(JSON_TipsParam json)
    {
    }

    [Token(Token = "0x600782B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TipsParam()
    {
    }
  }
}
