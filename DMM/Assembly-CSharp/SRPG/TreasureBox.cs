// Decompiled with JetBrains decompiler
// Type: SRPG.TreasureBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001175")]
  [AddComponentMenu("Common/TreasureBox")]
  public class TreasureBox : MonoBehaviour
  {
    [Token(Token = "0x4003F37")]
    [FieldOffset(Offset = "0xC")]
    public AnimationClip OpenAnimation;
    [Token(Token = "0x4003F38")]
    [FieldOffset(Offset = "0x10")]
    public float DropDelay;
    [Token(Token = "0x4003F39")]
    [FieldOffset(Offset = "0x14")]
    public float GoldDelay;
    [Token(Token = "0x4003F3A")]
    [FieldOffset(Offset = "0x18")]
    public Vector3 DropOffset;
    [Token(Token = "0x4003F3B")]
    [FieldOffset(Offset = "0x24")]
    private DropItemEffect mDropItem;
    [Token(Token = "0x4003F3C")]
    [FieldOffset(Offset = "0x28")]
    private bool mDropSpawned;
    [Token(Token = "0x4003F3D")]
    [FieldOffset(Offset = "0x29")]
    private bool mGoldSpawned;
    [Token(Token = "0x4003F3E")]
    [FieldOffset(Offset = "0x2A")]
    private bool mOpened;
    [Token(Token = "0x4003F3F")]
    [FieldOffset(Offset = "0x2C")]
    private DropGoldEffect mDropGold;

    [Token(Token = "0x17000823")]
    public Unit owner
    {
      [Token(Token = "0x6004A7A"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
      [Token(Token = "0x6004A7B"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x6004A7C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6004A7D")]
    [Address(RVA = "0x120CB40", Offset = "0x120B940", VA = "0x1120CB40")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6004A7E")]
    [Address(RVA = "0x120CAB0", Offset = "0x120B8B0", VA = "0x1120CAB0")]
    public bool IsPlaying() => new bool();

    [Token(Token = "0x6004A7F")]
    [Address(RVA = "0x120CF90", Offset = "0x120BD90", VA = "0x1120CF90")]
    private void Update()
    {
    }

    [Token(Token = "0x6004A80")]
    [Address(RVA = "0x120CBA0", Offset = "0x120B9A0", VA = "0x1120CBA0")]
    public void Open(
      Unit.DropItem DropItem,
      DropItemEffect dropItemTemplate,
      int numGolds,
      DropGoldEffect dropGoldTemplate)
    {
    }

    [Token(Token = "0x6004A81")]
    [Address(RVA = "0x120D1F0", Offset = "0x120BFF0", VA = "0x1120D1F0")]
    public TreasureBox()
    {
    }
  }
}
