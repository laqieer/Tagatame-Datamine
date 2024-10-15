// Decompiled with JetBrains decompiler
// Type: SRPG.UnitLevelUpConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C6E")]
  [AddComponentMenu("UI/UnitLevelUpConfirmWindow")]
  [FlowNode.Pin(0, "Close", FlowNode.PinTypes.Output, 0)]
  public class UnitLevelUpConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DBF7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform ItemLayoutParent;
    [Token(Token = "0x400DBF8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400DBF9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x400DBFA")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mExpItems;
    [Token(Token = "0x400DBFB")]
    [FieldOffset(Offset = "0x1C")]
    public UnitLevelUpConfirmWindow.ConfirmDecideEvent OnDecideEvent;
    [Token(Token = "0x400DBFC")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, int> mSelectItems;

    [Token(Token = "0x600CDDE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CDDF")]
    [Address(RVA = "0x98A720", Offset = "0x989520", VA = "0x1098A720")]
    private void Awake()
    {
    }

    [Token(Token = "0x600CDE0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CDE1")]
    [Address(RVA = "0x98A810", Offset = "0x989610", VA = "0x1098A810")]
    public void Refresh(Dictionary<string, int> dict)
    {
    }

    [Token(Token = "0x600CDE2")]
    [Address(RVA = "0x4506C0", Offset = "0x44F4C0", VA = "0x104506C0")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x600CDE3")]
    [Address(RVA = "0x98AB30", Offset = "0x989930", VA = "0x1098AB30")]
    public UnitLevelUpConfirmWindow()
    {
    }

    [Token(Token = "0x2002C6F")]
    public delegate void ConfirmDecideEvent();
  }
}
