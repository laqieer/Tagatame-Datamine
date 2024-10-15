// Decompiled with JetBrains decompiler
// Type: EventBackLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001B1")]
[AddComponentMenu("Event/EventBackLog")]
public class EventBackLog : MonoBehaviour
{
  [Token(Token = "0x40007F0")]
  [FieldOffset(Offset = "0xC")]
  private List<EventBackLogContent> mBackLogItems;
  [Token(Token = "0x40007F1")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private Transform mBackLogItemParent;
  [Token(Token = "0x40007F2")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private EventBackLogContent mBackLogItemPrefab;
  [Token(Token = "0x40007F3")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private SRPG_ScrollRect mScrollRect;
  [Token(Token = "0x40007F4")]
  [FieldOffset(Offset = "0x1C")]
  private bool mIsUpdate;

  [Token(Token = "0x6000A29")]
  [Address(RVA = "0xF46E50", Offset = "0xF45C50", VA = "0x10F46E50")]
  public void Add(string name, string text)
  {
  }

  [Token(Token = "0x17000153")]
  public bool CanOpen
  {
    [Token(Token = "0x6000A2A"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000A2B"), Address(RVA = "0x5EDEC0", Offset = "0x5ECCC0", VA = "0x105EDEC0")] set
    {
    }
  }

  [Token(Token = "0x17000154")]
  public int Count
  {
    [Token(Token = "0x6000A2C"), Address(RVA = "0xF47350", Offset = "0xF46150", VA = "0x10F47350")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x6000A2D")]
  [Address(RVA = "0xF47170", Offset = "0xF45F70", VA = "0x10F47170")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x6000A2E")]
  [Address(RVA = "0xF471B0", Offset = "0xF45FB0", VA = "0x10F471B0")]
  public void Open()
  {
  }

  [Token(Token = "0x6000A2F")]
  [Address(RVA = "0xF47030", Offset = "0xF45E30", VA = "0x10F47030")]
  public void Close()
  {
  }

  [Token(Token = "0x6000A30")]
  [Address(RVA = "0xF46F60", Offset = "0xF45D60", VA = "0x10F46F60")]
  public void Clear()
  {
  }

  [Token(Token = "0x6000A31")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A32")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A33")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000A34")]
  [Address(RVA = "0xF472E0", Offset = "0xF460E0", VA = "0x10F472E0")]
  public EventBackLog()
  {
  }
}
