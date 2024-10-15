// Decompiled with JetBrains decompiler
// Type: SRPG.UnitStatusPanel
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
  [Token(Token = "0x2002D03")]
  public class UnitStatusPanel : MonoBehaviour
  {
    [Token(Token = "0x400DFEB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400DFEC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UnitStatusPanelModel.Type mStatusType;
    [Token(Token = "0x400DFED")]
    [FieldOffset(Offset = "0x14")]
    private UnitStatusPanelModel mModel;

    [Token(Token = "0x600D195")]
    [Address(RVA = "0x9C99F0", Offset = "0x9C87F0", VA = "0x109C99F0")]
    public void Initialize(UnitData unitData, bool isHide = false)
    {
    }

    [Token(Token = "0x600D196")]
    [Address(RVA = "0x9C9AF0", Offset = "0x9C88F0", VA = "0x109C9AF0")]
    public void Setup(UnitData unitData, bool isHide = false)
    {
    }

    [Token(Token = "0x600D197")]
    [Address(RVA = "0x9C9A70", Offset = "0x9C8870", VA = "0x109C9A70")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600D198")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitStatusPanel()
    {
    }
  }
}
