// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopBtnBaloon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200237E")]
  [AddComponentMenu("UI/EventShopBtnBaloon")]
  public class EventShopBtnBaloon : MonoBehaviour
  {
    [Token(Token = "0x4009FB5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Image BaloonChar;
    [Token(Token = "0x4009FB6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image BaloonTextLeft;
    [Token(Token = "0x4009FB7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image BaloonTextRight;
    [Token(Token = "0x4009FB8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string ReverseObjectID;
    [Token(Token = "0x4009FB9")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public Sprite CurrentTextLeftSprite;
    [Token(Token = "0x4009FBA")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public Sprite CurrentTextRightSprite;
    [Token(Token = "0x4009FBB")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public Sprite CurrentCharSprite;
    [Token(Token = "0x4009FBC")]
    [FieldOffset(Offset = "0x28")]
    private GameObject mBaloonChar;
    [Token(Token = "0x4009FBD")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mBaloonTextLeft;
    [Token(Token = "0x4009FBE")]
    [FieldOffset(Offset = "0x30")]
    private GameObject mBaloonTextRight;

    [Token(Token = "0x600995E")]
    [Address(RVA = "0x5D7AA0", Offset = "0x5D68A0", VA = "0x105D7AA0")]
    private void Start()
    {
    }

    [Token(Token = "0x600995F")]
    [Address(RVA = "0x5D7870", Offset = "0x5D6670", VA = "0x105D7870")]
    private void RefreshBaloonImage()
    {
    }

    [Token(Token = "0x6009960")]
    [Address(RVA = "0x5D7CB0", Offset = "0x5D6AB0", VA = "0x105D7CB0")]
    private void UpdatePosition()
    {
    }

    [Token(Token = "0x6009961")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventShopBtnBaloon()
    {
    }
  }
}
