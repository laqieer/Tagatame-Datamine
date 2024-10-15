// Decompiled with JetBrains decompiler
// Type: SRPG.QuestSectionList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028C5")]
  [FlowNode.Pin(0, "ストーリーパート解放準備", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "アイテムが選択された", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ストーリーパート表示", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/QuestSectionList")]
  public class QuestSectionList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C372")]
    [FieldOffset(Offset = "0xC")]
    public ListItemEvents ItemTemplate;
    [Token(Token = "0x400C373")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemContainer;
    [Token(Token = "0x400C374")]
    [FieldOffset(Offset = "0x14")]
    public ScrollRect Scroll;
    [Token(Token = "0x400C375")]
    [FieldOffset(Offset = "0x18")]
    public string WorldMapControllerID;
    [Token(Token = "0x400C376")]
    [FieldOffset(Offset = "0x1C")]
    public bool RefreshOnStart;
    [Token(Token = "0x400C377")]
    [FieldOffset(Offset = "0x20")]
    public ImageArray StoryPartIcon;
    [Token(Token = "0x400C378")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [Header("スクロール位置を再計算する")]
    private SRPG_ScrollRect ChapterScrollRect;
    [Token(Token = "0x400C379")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x400C37A")]
    [FieldOffset(Offset = "0x2C")]
    private float BITING_PREVENT_VELOCITY;
    [Token(Token = "0x400C37B")]
    [FieldOffset(Offset = "0x30")]
    private List<ListItemEvents> mItems;

    [Token(Token = "0x600B84B")]
    [Address(RVA = "0x7F3A40", Offset = "0x7F2840", VA = "0x107F3A40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B84C")]
    [Address(RVA = "0x7F47C0", Offset = "0x7F35C0", VA = "0x107F47C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B84D")]
    [Address(RVA = "0x7F3D80", Offset = "0x7F2B80", VA = "0x107F3D80")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B84E")]
    [Address(RVA = "0x7F4710", Offset = "0x7F3510", VA = "0x107F4710")]
    public void ResetScroll()
    {
    }

    [Token(Token = "0x600B84F")]
    [Address(RVA = "0x7F44A0", Offset = "0x7F32A0", VA = "0x107F44A0")]
    public void ResetScrollPrevPosition()
    {
    }

    [Token(Token = "0x600B850")]
    [Address(RVA = "0x7F3A70", Offset = "0x7F2870", VA = "0x107F3A70")]
    private IEnumerator InitScroll(Vector2 vector) => (IEnumerator) null;

    [Token(Token = "0x600B851")]
    [Address(RVA = "0x7F3D10", Offset = "0x7F2B10", VA = "0x107F3D10")]
    public void OnSelectBackButton()
    {
    }

    [Token(Token = "0x600B852")]
    [Address(RVA = "0x7F3AF0", Offset = "0x7F28F0", VA = "0x107F3AF0")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B853")]
    [Address(RVA = "0x7F4850", Offset = "0x7F3650", VA = "0x107F4850")]
    public QuestSectionList()
    {
    }
  }
}
