// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ArtifactStoneEffectModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003305")]
  public class ArtifactStoneEffectModel
  {
    [Token(Token = "0x400F01D")]
    [FieldOffset(Offset = "0x8")]
    private string _effectName;
    [Token(Token = "0x400F01E")]
    [FieldOffset(Offset = "0xC")]
    private string _effectExpr;
    [Token(Token = "0x400F01F")]
    [FieldOffset(Offset = "0x10")]
    private int _effectFrame;
    [Token(Token = "0x400F020")]
    [FieldOffset(Offset = "0x14")]
    private string _effectIconName;
    [Token(Token = "0x400F021")]
    [FieldOffset(Offset = "0x18")]
    private bool _isOpenStoneEffect;

    [Token(Token = "0x17001D27")]
    public string EffectName
    {
      [Token(Token = "0x600E00F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D28")]
    public string EffectExpr
    {
      [Token(Token = "0x600E010"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D29")]
    public int EffectFrame
    {
      [Token(Token = "0x600E011"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D2A")]
    public string EffectIconName
    {
      [Token(Token = "0x600E012"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D2B")]
    public bool IsOpenStoneEffect
    {
      [Token(Token = "0x600E013"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E014")]
    [Address(RVA = "0xAA7DC0", Offset = "0xAA6BC0", VA = "0x10AA7DC0")]
    public void Initialize(ArtifactStoneEffectParam param, bool is_open = true)
    {
    }

    [Token(Token = "0x600E015")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtifactStoneEffectModel()
    {
    }
  }
}
