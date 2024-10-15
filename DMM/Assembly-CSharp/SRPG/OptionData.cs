// Decompiled with JetBrains decompiler
// Type: SRPG.OptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FE5")]
  public class OptionData
  {
    [Token(Token = "0x4003830")]
    [FieldOffset(Offset = "0x8")]
    private VolumeData mVolume;

    [Token(Token = "0x170005FC")]
    public VolumeData Volume
    {
      [Token(Token = "0x600421D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (VolumeData) null;
      }
    }

    [Token(Token = "0x600421E")]
    [Address(RVA = "0x119AE10", Offset = "0x1199C10", VA = "0x1119AE10")]
    public OptionData()
    {
    }
  }
}
