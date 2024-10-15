// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawEbaleSetEff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002986")]
  [AddComponentMenu("UI/Rune/RuneDrawEbaleSetEff")]
  public class RuneDrawEbaleSetEff : MonoBehaviour
  {
    [Token(Token = "0x400C888")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mSetEffParentOn;
    [Token(Token = "0x400C889")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mSetEffParentOff;
    [Token(Token = "0x400C88A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RectTransform mSetEffListParent;
    [Token(Token = "0x400C88B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mSetEffStatusList;
    [Token(Token = "0x400C88C")]
    [FieldOffset(Offset = "0x1C")]
    private List<GameObject> mListItems;
    [Token(Token = "0x400C88D")]
    [FieldOffset(Offset = "0x20")]
    private UnitData mUnitData;
    [Token(Token = "0x400C88E")]
    [FieldOffset(Offset = "0x24")]
    private bool isStart;

    [Token(Token = "0x600BC28")]
    [Address(RVA = "0x83E0C0", Offset = "0x83CEC0", VA = "0x1083E0C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BC29")]
    [Address(RVA = "0x83E090", Offset = "0x83CE90", VA = "0x1083E090")]
    public void SetData(UnitData unit)
    {
    }

    [Token(Token = "0x600BC2A")]
    [Address(RVA = "0x83DA80", Offset = "0x83C880", VA = "0x1083DA80")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC2B")]
    [Address(RVA = "0x83D960", Offset = "0x83C760", VA = "0x1083D960")]
    private void ClearObjects()
    {
    }

    [Token(Token = "0x600BC2C")]
    [Address(RVA = "0x83E150", Offset = "0x83CF50", VA = "0x1083E150")]
    public RuneDrawEbaleSetEff()
    {
    }

    [Token(Token = "0x2002987")]
    private class ViewData
    {
      [Token(Token = "0x400C88F")]
      [FieldOffset(Offset = "0x8")]
      public string m_Name;
      [Token(Token = "0x400C890")]
      [FieldOffset(Offset = "0xC")]
      public int m_IconIndex;
      [Token(Token = "0x400C891")]
      [FieldOffset(Offset = "0x10")]
      public int m_SetEffType;
      [Token(Token = "0x400C892")]
      [FieldOffset(Offset = "0x14")]
      public BaseStatus m_AddStatus;
      [Token(Token = "0x400C893")]
      [FieldOffset(Offset = "0x18")]
      public BaseStatus m_ScaleStatus;

      [Token(Token = "0x600BC2D")]
      [Address(RVA = "0x83F180", Offset = "0x83DF80", VA = "0x1083F180")]
      public ViewData()
      {
      }
    }
  }
}
