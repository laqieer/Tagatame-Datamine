// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePotentialSlotData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011CE")]
  [MessagePackObject(true)]
  public class RunePridePotentialSlotData : BaseParameterData
  {
    [Token(Token = "0x40040B6")]
    [FieldOffset(Offset = "0x20")]
    private string iname;

    [Token(Token = "0x1700084C")]
    public string Iname
    {
      [Token(Token = "0x6004B4B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6004B4C")]
    [Address(RVA = "0x1203510", Offset = "0x1202310", VA = "0x11203510")]
    public void Deserialize(JSON_RunePridePotentialSlotData json)
    {
    }

    [Token(Token = "0x6004B4D")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public RunePridePotentialSlotData()
    {
    }
  }
}
