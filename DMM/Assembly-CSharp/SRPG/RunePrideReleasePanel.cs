// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideReleasePanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011CD")]
  [MessagePackObject(true)]
  public class RunePrideReleasePanel
  {
    [Token(Token = "0x40040B4")]
    [FieldOffset(Offset = "0x8")]
    private string panel_iname;
    [Token(Token = "0x40040B5")]
    [FieldOffset(Offset = "0xC")]
    private List<int> release;

    [Token(Token = "0x1700084A")]
    public string PanelIname
    {
      [Token(Token = "0x6004B46"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700084B")]
    public List<int> ReleaseSquareIds
    {
      [Token(Token = "0x6004B47"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6004B48"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x6004B49")]
    [Address(RVA = "0x1203580", Offset = "0x1202380", VA = "0x11203580")]
    public void Deserialize(JSON_RunePrideReleasePanel json)
    {
    }

    [Token(Token = "0x6004B4A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideReleasePanel()
    {
    }
  }
}
