// Decompiled with JetBrains decompiler
// Type: SRPG.ShamCopyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200119D")]
  public class ShamCopyData
  {
    [Token(Token = "0x4003FED")]
    [FieldOffset(Offset = "0x8")]
    public bool isUnitChange;
    [Token(Token = "0x4003FEE")]
    [FieldOffset(Offset = "0x9")]
    public bool isArtifactChange;
    [Token(Token = "0x4003FEF")]
    [FieldOffset(Offset = "0xA")]
    public bool isConceptCardChange;
    [Token(Token = "0x4003FF0")]
    [FieldOffset(Offset = "0xB")]
    public bool isRuneChange;
    [Token(Token = "0x4003FF1")]
    [FieldOffset(Offset = "0xC")]
    public bool isCrystalChange;
    [Token(Token = "0x4003FF2")]
    [FieldOffset(Offset = "0xD")]
    public bool isMapNotChange;
    [Token(Token = "0x4003FF3")]
    [FieldOffset(Offset = "0xE")]
    public bool isNotUnit;
    [Token(Token = "0x4003FF4")]
    [FieldOffset(Offset = "0xF")]
    public bool isUnitUsed;
    [Token(Token = "0x4003FF5")]
    [FieldOffset(Offset = "0x10")]
    public bool isArtifactUsed;
    [Token(Token = "0x4003FF6")]
    [FieldOffset(Offset = "0x11")]
    public bool isRuneUsed;
    [Token(Token = "0x4003FF7")]
    [FieldOffset(Offset = "0x12")]
    public bool isCrystalUsed;
    [Token(Token = "0x4003FF8")]
    [FieldOffset(Offset = "0x13")]
    public bool isConceptUsed;
    [Token(Token = "0x4003FF9")]
    [FieldOffset(Offset = "0x14")]
    public bool isMapUsed;

    [Token(Token = "0x17000848")]
    public bool isEquipChange
    {
      [Token(Token = "0x6004B15"), Address(RVA = "0x1206200", Offset = "0x1205000", VA = "0x11206200")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000849")]
    public bool isUsed
    {
      [Token(Token = "0x6004B16"), Address(RVA = "0x1206230", Offset = "0x1205030", VA = "0x11206230")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004B17")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ShamCopyData()
    {
    }
  }
}
