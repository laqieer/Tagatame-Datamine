// Decompiled with JetBrains decompiler
// Type: SRPG.AppealItemBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FB7")]
  [AddComponentMenu("UI/AppealItemBase")]
  public class AppealItemBase : MonoBehaviour
  {
    [Token(Token = "0x4008663")]
    [FieldOffset(Offset = "0xC")]
    private Sprite mAppealSprite;
    [Token(Token = "0x4008664")]
    [FieldOffset(Offset = "0x10")]
    public Image AppealObject;

    [Token(Token = "0x170012C6")]
    public Sprite AppealSprite
    {
      [Token(Token = "0x60082AB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x60082AC"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x60082AD")]
    [Address(RVA = "0x434EC0", Offset = "0x433CC0", VA = "0x10434EC0", Slot = "4")]
    protected virtual void Awake()
    {
    }

    [Token(Token = "0x60082AE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x60082AF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x60082B0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    protected virtual void Destroy()
    {
    }

    [Token(Token = "0x60082B1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x60082B2")]
    [Address(RVA = "0x434F40", Offset = "0x433D40", VA = "0x10434F40", Slot = "9")]
    protected virtual void Refresh()
    {
    }

    [Token(Token = "0x60082B3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AppealItemBase()
    {
    }
  }
}
