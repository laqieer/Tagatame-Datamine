// Decompiled with JetBrains decompiler
// Type: SRPG.DropItemEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EAD")]
  [AddComponentMenu("Common/DropItemEffect")]
  public class DropItemEffect : MonoBehaviour
  {
    [Token(Token = "0x4002D02")]
    private const string TREASURE_GAMEOBJECT_NAME = "UI_TREASURE";
    [Token(Token = "0x4002D03")]
    [FieldOffset(Offset = "0xC")]
    private DropItemEffect.State m_State;
    [Token(Token = "0x4002D04")]
    [FieldOffset(Offset = "0x10")]
    private RectTransform m_TargetRect;
    [Token(Token = "0x4002D05")]
    [FieldOffset(Offset = "0x14")]
    private ItemIcon m_ItemIcon;
    [Token(Token = "0x4002D06")]
    [FieldOffset(Offset = "0x18")]
    private Unit m_DropOwner;
    [Token(Token = "0x4002D07")]
    [FieldOffset(Offset = "0x1C")]
    private Unit.DropItem m_DropItem;
    [Token(Token = "0x4002D08")]
    [FieldOffset(Offset = "0x20")]
    public float Acceleration;
    [Token(Token = "0x4002D09")]
    [FieldOffset(Offset = "0x24")]
    public float Delay;
    [Token(Token = "0x4002D0A")]
    [FieldOffset(Offset = "0x28")]
    private float m_Speed;
    [Token(Token = "0x4002D0B")]
    [FieldOffset(Offset = "0x2C")]
    private Animator m_EndAnimator;
    [Token(Token = "0x4002D0C")]
    [FieldOffset(Offset = "0x30")]
    public float OpenWait;
    [Token(Token = "0x4002D0D")]
    [FieldOffset(Offset = "0x34")]
    public float PopSpeed;
    [Token(Token = "0x4002D0E")]
    [FieldOffset(Offset = "0x38")]
    private float m_PopSpeed;
    [Token(Token = "0x4002D0F")]
    [FieldOffset(Offset = "0x3C")]
    private float m_ScaleSpeed;
    [Token(Token = "0x4002D10")]
    [FieldOffset(Offset = "0x40")]
    private float m_DeleteDelay;

    [Token(Token = "0x170004DC")]
    public RectTransform TargetRect
    {
      [Token(Token = "0x6003D0D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170004DD")]
    public Unit DropOwner
    {
      [Token(Token = "0x6003D0E"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
      [Token(Token = "0x6003D0F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x170004DE")]
    public Unit.DropItem DropItem
    {
      [Token(Token = "0x6003D10"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x6003D11")]
    [Address(RVA = "0x10F72A0", Offset = "0x10F60A0", VA = "0x110F72A0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003D12")]
    [Address(RVA = "0x10F8080", Offset = "0x10F6E80", VA = "0x110F8080")]
    private void Update()
    {
    }

    [Token(Token = "0x6003D13")]
    [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
    public void SetItem(Unit.DropItem item)
    {
    }

    [Token(Token = "0x6003D14")]
    [Address(RVA = "0x10F6DD0", Offset = "0x10F5BD0", VA = "0x110F6DD0")]
    private void Hide()
    {
    }

    [Token(Token = "0x6003D15")]
    [Address(RVA = "0x10F6FF0", Offset = "0x10F5DF0", VA = "0x110F6FF0")]
    private void Show()
    {
    }

    [Token(Token = "0x6003D16")]
    [Address(RVA = "0x10F7C20", Offset = "0x10F6A20", VA = "0x110F7C20")]
    private void State_Setup()
    {
    }

    [Token(Token = "0x6003D17")]
    [Address(RVA = "0x10F78E0", Offset = "0x10F66E0", VA = "0x110F78E0")]
    private void State_Open()
    {
    }

    [Token(Token = "0x6003D18")]
    [Address(RVA = "0x10F7A10", Offset = "0x10F6810", VA = "0x110F7A10")]
    private void State_Popup()
    {
    }

    [Token(Token = "0x6003D19")]
    [Address(RVA = "0x10F7480", Offset = "0x10F6280", VA = "0x110F7480")]
    private void State_Move()
    {
    }

    [Token(Token = "0x6003D1A")]
    [Address(RVA = "0x10F7340", Offset = "0x10F6140", VA = "0x110F7340")]
    private void State_End()
    {
    }

    [Token(Token = "0x6003D1B")]
    [Address(RVA = "0x10F72B0", Offset = "0x10F60B0", VA = "0x110F72B0")]
    private void State_Delete()
    {
    }

    [Token(Token = "0x6003D1C")]
    [Address(RVA = "0x10F83C0", Offset = "0x10F71C0", VA = "0x110F83C0")]
    public DropItemEffect()
    {
    }

    [Token(Token = "0x2000EAE")]
    private enum State
    {
      [Token(Token = "0x4002D12")] NONE,
      [Token(Token = "0x4002D13")] SETUP,
      [Token(Token = "0x4002D14")] OPEN,
      [Token(Token = "0x4002D15")] POPUP,
      [Token(Token = "0x4002D16")] MOVE,
      [Token(Token = "0x4002D17")] END,
      [Token(Token = "0x4002D18")] DELETE,
    }
  }
}
