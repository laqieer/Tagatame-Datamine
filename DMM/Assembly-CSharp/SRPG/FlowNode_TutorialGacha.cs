// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TutorialGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200165C")]
  [FlowNode.NodeType("UI/Tutorial Gacha")]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Finished", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_TutorialGacha : FlowNode
  {
    [Token(Token = "0x4005130")]
    private const int PIN_IN_TUTORIAL_GACHA_START = 0;
    [Token(Token = "0x4005131")]
    private const int PIN_OU_TUTORIAL_GACHA_FINISHED = 1;
    [Token(Token = "0x4005132")]
    [FieldOffset(Offset = "0x18")]
    public int UnitIndex;
    [Token(Token = "0x4005133")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsResourcePath(typeof (GachaController))]
    public string Prefab_GachaController;
    [Token(Token = "0x4005134")]
    [FieldOffset(Offset = "0x20")]
    [StringIsResourcePath(typeof (TutorialGacha))]
    [SerializeField]
    public string Prefab_TutorialGacha;
    [Token(Token = "0x4005135")]
    [FieldOffset(Offset = "0x24")]
    private GachaController mGachaController;
    [Token(Token = "0x4005136")]
    [FieldOffset(Offset = "0x28")]
    private TutorialGacha m_TutorialGacha;

    [Token(Token = "0x6005BCD")]
    [Address(RVA = "0x1311720", Offset = "0x1310520", VA = "0x11311720", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005BCE")]
    [Address(RVA = "0x1311690", Offset = "0x1310490", VA = "0x11311690", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BCF")]
    [Address(RVA = "0x13117D0", Offset = "0x13105D0", VA = "0x113117D0")]
    private IEnumerator PlayGachaAsync() => (IEnumerator) null;

    [Token(Token = "0x6005BD0")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Finished()
    {
    }

    [Token(Token = "0x6005BD1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_TutorialGacha()
    {
    }
  }
}
