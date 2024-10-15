// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CountAnimationModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003312")]
  public class CountAnimationModel
  {
    [Token(Token = "0x400F0C6")]
    [FieldOffset(Offset = "0x8")]
    private int _max_frame;
    [Token(Token = "0x400F0C7")]
    [FieldOffset(Offset = "0xC")]
    private bool _isAnimation;
    [Token(Token = "0x400F0C8")]
    [FieldOffset(Offset = "0xD")]
    private bool _isSymbol;
    [Token(Token = "0x400F0C9")]
    [FieldOffset(Offset = "0x10")]
    private float _totalScore;
    [Token(Token = "0x400F0CA")]
    [FieldOffset(Offset = "0x14")]
    private float _addScore;

    [Token(Token = "0x17001D8A")]
    public float TotalScore
    {
      [Token(Token = "0x600E0BF"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001D8B")]
    public float AddScore
    {
      [Token(Token = "0x600E0C0"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001D8C")]
    public int Max_frame
    {
      [Token(Token = "0x600E0C1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D8D")]
    public bool IsSymbol
    {
      [Token(Token = "0x600E0C2"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D8E")]
    public bool IsAnimation
    {
      [Token(Token = "0x600E0C3"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E0C4"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] set
      {
      }
    }

    [Token(Token = "0x600E0C5")]
    [Address(RVA = "0xAACB80", Offset = "0xAAB980", VA = "0x10AACB80")]
    public void Initialize(float totalScore, float addScore, int max_frame, bool isSymbol = false)
    {
    }

    [Token(Token = "0x600E0C6")]
    [Address(RVA = "0xAACBB0", Offset = "0xAAB9B0", VA = "0x10AACBB0")]
    public CountAnimationModel()
    {
    }
  }
}
