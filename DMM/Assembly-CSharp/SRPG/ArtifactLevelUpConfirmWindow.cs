// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactLevelUpConfirmWindow
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
  [Token(Token = "0x2002006")]
  [FlowNode.Pin(0, "Close", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("UI/ArtifactLevelUpConfirmWindow")]
  public class ArtifactLevelUpConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40088AA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform ItemLayoutParent;
    [Token(Token = "0x40088AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x40088AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x40088AD")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mExpItems;
    [Token(Token = "0x40088AE")]
    [FieldOffset(Offset = "0x1C")]
    public ArtifactLevelUpConfirmWindow.ConfirmDecideEvent OnDecideEvent;
    [Token(Token = "0x40088AF")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, int> mSelectItems;

    [Token(Token = "0x6008451")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008452")]
    [Address(RVA = "0x4505D0", Offset = "0x44F3D0", VA = "0x104505D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008453")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008454")]
    [Address(RVA = "0x4506F0", Offset = "0x44F4F0", VA = "0x104506F0")]
    public void Refresh(Dictionary<string, int> dict)
    {
    }

    [Token(Token = "0x6008455")]
    [Address(RVA = "0x4506C0", Offset = "0x44F4C0", VA = "0x104506C0")]
    private void OnDecide()
    {
    }

    [Token(Token = "0x6008456")]
    [Address(RVA = "0x450A10", Offset = "0x44F810", VA = "0x10450A10")]
    public ArtifactLevelUpConfirmWindow()
    {
    }

    [Token(Token = "0x2002007")]
    public delegate void ConfirmDecideEvent();
  }
}
