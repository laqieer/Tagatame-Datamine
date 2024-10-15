// Decompiled with JetBrains decompiler
// Type: SRPG.BattleStamp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002085")]
  [AddComponentMenu("UI/BattleStamp")]
  public class BattleStamp : MonoBehaviour
  {
    [Token(Token = "0x4008C20")]
    [FieldOffset(Offset = "0xC")]
    public BattleStamp.SelectEvent OnSelectItem;
    [Token(Token = "0x4008C21")]
    [FieldOffset(Offset = "0x10")]
    public RectTransform ListParent;
    [Token(Token = "0x4008C22")]
    [FieldOffset(Offset = "0x14")]
    public ListItemEvents ItemTemplate;
    [Token(Token = "0x4008C23")]
    [FieldOffset(Offset = "0x18")]
    public Sprite[] Sprites;
    [Token(Token = "0x4008C24")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject[] Prefabs;
    [Token(Token = "0x4008C25")]
    [FieldOffset(Offset = "0x20")]
    public string SpriteGameObjectID;
    [Token(Token = "0x4008C26")]
    [FieldOffset(Offset = "0x24")]
    public string SelectCursorGameObjectID;
    [Token(Token = "0x4008C27")]
    [FieldOffset(Offset = "0x28")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x4008C28")]
    [FieldOffset(Offset = "0x2C")]
    private int mSelectID;

    [Token(Token = "0x17001329")]
    public int SelectStampID
    {
      [Token(Token = "0x600875A"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600875B")]
    [Address(RVA = "0x4897C0", Offset = "0x4885C0", VA = "0x104897C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600875C")]
    [Address(RVA = "0x4893B0", Offset = "0x4881B0", VA = "0x104893B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600875D")]
    [Address(RVA = "0x489B30", Offset = "0x488930", VA = "0x10489B30")]
    public BattleStamp()
    {
    }

    [Token(Token = "0x2002086")]
    public delegate void SelectEvent(Sprite sprite);
  }
}
