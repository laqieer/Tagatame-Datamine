// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopBtnBaloon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026C3")]
  [AddComponentMenu("UI/LimitedShopBtnBaloon")]
  public class LimitedShopBtnBaloon : MonoBehaviour
  {
    [Token(Token = "0x400B5D0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Image BaloonChar;
    [Token(Token = "0x400B5D1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image BaloonTextLeft;
    [Token(Token = "0x400B5D2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image BaloonTextRight;
    [Token(Token = "0x400B5D3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string ReverseObjectID;
    [Token(Token = "0x400B5D4")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public Sprite CurrentTextLeftSprite;
    [Token(Token = "0x400B5D5")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public Sprite CurrentTextRightSprite;
    [Token(Token = "0x400B5D6")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public Sprite CurrentCharSprite;
    [Token(Token = "0x400B5D7")]
    [FieldOffset(Offset = "0x28")]
    private GameObject mBaloonChar;
    [Token(Token = "0x400B5D8")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mBaloonTextLeft;
    [Token(Token = "0x400B5D9")]
    [FieldOffset(Offset = "0x30")]
    private GameObject mBaloonTextRight;

    [Token(Token = "0x600AD7D")]
    [Address(RVA = "0x714470", Offset = "0x713270", VA = "0x10714470")]
    private void Start()
    {
    }

    [Token(Token = "0x600AD7E")]
    [Address(RVA = "0x714240", Offset = "0x713040", VA = "0x10714240")]
    private void RefreshBaloonImage()
    {
    }

    [Token(Token = "0x600AD7F")]
    [Address(RVA = "0x714680", Offset = "0x713480", VA = "0x10714680")]
    private void UpdatePosition()
    {
    }

    [Token(Token = "0x600AD80")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LimitedShopBtnBaloon()
    {
    }
  }
}
