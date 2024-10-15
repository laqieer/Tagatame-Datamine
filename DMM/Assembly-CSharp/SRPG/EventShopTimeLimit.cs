// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopTimeLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EB9")]
  [AddComponentMenu("Common/EventShopTimeLimit")]
  public class EventShopTimeLimit : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4002D48")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Body;
    [Token(Token = "0x4002D49")]
    [FieldOffset(Offset = "0x10")]
    public Text Timer;
    [Token(Token = "0x4002D4A")]
    [FieldOffset(Offset = "0x18")]
    private long mEndTime;
    [Token(Token = "0x4002D4B")]
    [FieldOffset(Offset = "0x20")]
    private float mRefreshInterval;
    [Token(Token = "0x4002D4C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private string[] HIDE_TIME_LIMIT_SHOP_NAMES;
    [Token(Token = "0x4002D4D")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsDisplay;

    [Token(Token = "0x6003D35")]
    [Address(RVA = "0x10F9FA0", Offset = "0x10F8DA0", VA = "0x110F9FA0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003D36")]
    [Address(RVA = "0x10FA180", Offset = "0x10F8F80", VA = "0x110FA180")]
    private void Update()
    {
    }

    [Token(Token = "0x6003D37")]
    [Address(RVA = "0x10F9B10", Offset = "0x10F8910", VA = "0x110F9B10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6003D38")]
    [Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x110F9FD0", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6003D39")]
    [Address(RVA = "0x10FA1D0", Offset = "0x10F8FD0", VA = "0x110FA1D0")]
    public EventShopTimeLimit()
    {
    }
  }
}
