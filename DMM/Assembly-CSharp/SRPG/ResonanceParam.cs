// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CBE")]
  [MessagePackObject(true)]
  public class ResonanceParam
  {
    [Token(Token = "0x40070C5")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40070C6")]
    [FieldOffset(Offset = "0xC")]
    private string mResonanceRecipeIname;
    [Token(Token = "0x40070C7")]
    [FieldOffset(Offset = "0x10")]
    private string mLimitRate;
    [Token(Token = "0x40070C8")]
    [FieldOffset(Offset = "0x14")]
    private ResonanceUnitParam[] mUnits;

    [Token(Token = "0x17000F5B")]
    public string Iname
    {
      [Token(Token = "0x6007646"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F5C")]
    public string ResonanceRecipeIname
    {
      [Token(Token = "0x6007647"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F5D")]
    public string LimitRate
    {
      [Token(Token = "0x6007648"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F5E")]
    public ResonanceUnitParam[] Units
    {
      [Token(Token = "0x6007649"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (ResonanceUnitParam[]) null;
      }
    }

    [Token(Token = "0x600764A")]
    [Address(RVA = "0x397A20", Offset = "0x396820", VA = "0x10397A20")]
    public bool Deserialize(JSON_ResonanceParam json) => new bool();

    [Token(Token = "0x600764B")]
    [Address(RVA = "0x3978E0", Offset = "0x3966E0", VA = "0x103978E0")]
    public static bool Deserialize(ref List<ResonanceParam> paramList, JSON_ResonanceParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600764C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceParam()
    {
    }
  }
}
