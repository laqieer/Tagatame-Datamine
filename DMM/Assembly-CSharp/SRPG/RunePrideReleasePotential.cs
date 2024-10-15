// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideReleasePotential
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011CF")]
  [MessagePackObject(true)]
  public class RunePrideReleasePotential
  {
    [Token(Token = "0x40040B7")]
    [FieldOffset(Offset = "0x8")]
    private string bonus_iname;
    [Token(Token = "0x40040B8")]
    [FieldOffset(Offset = "0xC")]
    private List<RunePridePotentialSlotData> slots;

    [Token(Token = "0x1700084D")]
    public string BonusIname
    {
      [Token(Token = "0x6004B4E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700084E")]
    public List<RunePridePotentialSlotData> Slots
    {
      [Token(Token = "0x6004B4F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RunePridePotentialSlotData>) null;
      }
      [Token(Token = "0x6004B50"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x6004B51")]
    [Address(RVA = "0x12036D0", Offset = "0x12024D0", VA = "0x112036D0")]
    public void Deserialize(JSON_RunePrideReleasePotential json)
    {
    }

    [Token(Token = "0x6004B52")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideReleasePotential()
    {
    }
  }
}
