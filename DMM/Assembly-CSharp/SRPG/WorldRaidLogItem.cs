// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidLogItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D67")]
  [AddComponentMenu("UI/WorldRaid/WorldRaidLogItem")]
  [FlowNode.Pin(1, "上アニメーション開始", FlowNode.PinTypes.Output, 1)]
  public class WorldRaidLogItem : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E25C")]
    public const int PIN_OUT_MOVE_ITEM = 1;
    [Token(Token = "0x400E25D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text UserNameText;
    [Token(Token = "0x400E25E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private BitmapText DamageText;
    [Token(Token = "0x400E25F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private PolyImage BossIcon;
    [Token(Token = "0x400E260")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup CanvasGroup;
    [Token(Token = "0x400E261")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float[] AlphaList;
    [Token(Token = "0x400E262")]
    [FieldOffset(Offset = "0x20")]
    private WorldRaidLogData mData;
    [Token(Token = "0x400E263")]
    [FieldOffset(Offset = "0x24")]
    private int mIndex;
    [Token(Token = "0x400E264")]
    [FieldOffset(Offset = "0x28")]
    private Transform mSecondParent;

    [Token(Token = "0x600D394")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D395")]
    [Address(RVA = "0x9E6750", Offset = "0x9E5550", VA = "0x109E6750")]
    public void SetUp(WorldRaidLogData _data, Transform _second_parent)
    {
    }

    [Token(Token = "0x600D396")]
    [Address(RVA = "0x9E65E0", Offset = "0x9E53E0", VA = "0x109E65E0")]
    public void ItemMove()
    {
    }

    [Token(Token = "0x600D397")]
    [Address(RVA = "0x9E66F0", Offset = "0x9E54F0", VA = "0x109E66F0")]
    public void RemoveItem()
    {
    }

    [Token(Token = "0x600D398")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldRaidLogItem()
    {
    }
  }
}
