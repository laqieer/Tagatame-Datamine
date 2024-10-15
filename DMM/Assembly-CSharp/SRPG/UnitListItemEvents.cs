// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListItemEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C86")]
  public class UnitListItemEvents : ListItemEvents
  {
    [Token(Token = "0x400DC78")]
    private const float CHANGE_INTERBAL = 2f;
    [Token(Token = "0x400DC79")]
    [FieldOffset(Offset = "0x38")]
    public Image[] EqIcons;
    [Token(Token = "0x400DC7A")]
    [FieldOffset(Offset = "0x3C")]
    public Image[] AttrIcons;
    [Token(Token = "0x400DC7B")]
    [FieldOffset(Offset = "0x40")]
    public GameObject Badge;
    [Token(Token = "0x400DC7C")]
    [FieldOffset(Offset = "0x44")]
    public GameObject CharacterQuestBadge;
    [Token(Token = "0x400DC7D")]
    [FieldOffset(Offset = "0x48")]
    public GameObject FavoriteBadge;
    [Token(Token = "0x400DC7E")]
    [FieldOffset(Offset = "0x4C")]
    public bool DispAlternate;
    [Token(Token = "0x400DC7F")]
    [FieldOffset(Offset = "0x50")]
    private int m_Index;
    [Token(Token = "0x400DC80")]
    [FieldOffset(Offset = "0x54")]
    private float m_Time;

    [Token(Token = "0x600CE69")]
    [Address(RVA = "0x995580", Offset = "0x994380", VA = "0x10995580")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600CE6A")]
    [Address(RVA = "0x995B10", Offset = "0x994910", VA = "0x10995B10")]
    private void Start()
    {
    }

    [Token(Token = "0x600CE6B")]
    [Address(RVA = "0x995590", Offset = "0x994390", VA = "0x10995590")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600CE6C")]
    [Address(RVA = "0x9961C0", Offset = "0x994FC0", VA = "0x109961C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600CE6D")]
    [Address(RVA = "0x995FC0", Offset = "0x994DC0", VA = "0x10995FC0")]
    private void UpdateBadgeDefault()
    {
    }

    [Token(Token = "0x600CE6E")]
    [Address(RVA = "0x995B80", Offset = "0x994980", VA = "0x10995B80")]
    private void UpdateBadgeAlternate()
    {
    }

    [Token(Token = "0x600CE6F")]
    [Address(RVA = "0x43AD40", Offset = "0x439B40", VA = "0x1043AD40")]
    public UnitListItemEvents()
    {
    }
  }
}
