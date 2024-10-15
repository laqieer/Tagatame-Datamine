// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A04")]
  public class RunePrideButton : MonoBehaviour
  {
    [Token(Token = "0x400CC26")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CC27")]
    [FieldOffset(Offset = "0x10")]
    private RunePrideButtonModel mModel;
    [Token(Token = "0x400CC28")]
    [FieldOffset(Offset = "0x14")]
    private UnitData mUnitData;

    [Token(Token = "0x600BF7F")]
    [Address(RVA = "0x87ED00", Offset = "0x87DB00", VA = "0x1087ED00")]
    public void SetUp(UnitData _unit_data)
    {
    }

    [Token(Token = "0x600BF80")]
    [Address(RVA = "0x87EC80", Offset = "0x87DA80", VA = "0x1087EC80")]
    private void Draw()
    {
    }

    [Token(Token = "0x600BF81")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePrideButton()
    {
    }
  }
}
