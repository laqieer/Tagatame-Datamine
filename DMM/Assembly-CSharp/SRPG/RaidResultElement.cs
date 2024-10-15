// Decompiled with JetBrains decompiler
// Type: SRPG.RaidResultElement
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
  [Token(Token = "0x20028F6")]
  [AddComponentMenu("UI/RaidResultElement")]
  public class RaidResultElement : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C4FE")]
    [FieldOffset(Offset = "0xC")]
    public Text TxtTitle;
    [Token(Token = "0x400C4FF")]
    [FieldOffset(Offset = "0x10")]
    public Text TxtExp;
    [Token(Token = "0x400C500")]
    [FieldOffset(Offset = "0x14")]
    public Text TxtGold;
    [Token(Token = "0x400C501")]
    [FieldOffset(Offset = "0x18")]
    public Transform ItemParent;
    [Token(Token = "0x400C502")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C503")]
    [FieldOffset(Offset = "0x20")]
    [Description("入手アイテムを可視状態に切り替えるトリガー")]
    public string Treasure_TurnOnTrigger;
    [Token(Token = "0x400C504")]
    [FieldOffset(Offset = "0x24")]
    [Description("入手アイテムを可視状態に切り替える間隔 (秒数)")]
    public float Treasure_TriggerInterval;
    [Token(Token = "0x400C505")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> mItems;
    [Token(Token = "0x400C506")]
    [FieldOffset(Offset = "0x2C")]
    private bool mRequest;
    [Token(Token = "0x400C507")]
    [FieldOffset(Offset = "0x2D")]
    private bool mFinished;
    [Token(Token = "0x400C508")]
    [FieldOffset(Offset = "0x30")]
    private float mTimeScale;

    [Token(Token = "0x1700195C")]
    public float TimeScale
    {
      [Token(Token = "0x600B963"), Address(RVA = "0x2A2960", Offset = "0x2A1760", VA = "0x102A2960")] get
      {
        return new float();
      }
      [Token(Token = "0x600B964"), Address(RVA = "0x806C40", Offset = "0x805A40", VA = "0x10806C40")] set
      {
      }
    }

    [Token(Token = "0x600B965")]
    [Address(RVA = "0x806B00", Offset = "0x805900", VA = "0x10806B00")]
    public void Start()
    {
    }

    [Token(Token = "0x600B966")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B967")]
    [Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")]
    public bool IsRequest() => new bool();

    [Token(Token = "0x600B968")]
    [Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")]
    public bool IsFinished() => new bool();

    [Token(Token = "0x600B969")]
    [Address(RVA = "0x806700", Offset = "0x805500", VA = "0x10806700")]
    public void RequestAnimation()
    {
    }

    [Token(Token = "0x600B96A")]
    [Address(RVA = "0x806B70", Offset = "0x805970", VA = "0x10806B70")]
    private IEnumerator TreasureAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B96B")]
    [Address(RVA = "0x806BE0", Offset = "0x8059E0", VA = "0x10806BE0")]
    public RaidResultElement()
    {
    }
  }
}
