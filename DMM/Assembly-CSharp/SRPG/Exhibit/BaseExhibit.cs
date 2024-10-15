// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.BaseExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200342F")]
  public class BaseExhibit : MonoBehaviour, IExhibit
  {
    [Token(Token = "0x400F78D")]
    [FieldOffset(Offset = "0xC")]
    [CustomGroup("テキスト")]
    [CustomField("テキスト", CustomFieldAttribute.Type.UIText)]
    public Text m_Text;
    [Token(Token = "0x400F78E")]
    [FieldOffset(Offset = "0x10")]
    [CustomField("ボタン", CustomFieldAttribute.Type.UIButton)]
    [CustomGroup("ボタン")]
    public Button m_Button;
    [Token(Token = "0x400F78F")]
    [FieldOffset(Offset = "0x14")]
    [CustomField("スライダー", CustomFieldAttribute.Type.UISlider)]
    [CustomGroup("スライダー")]
    public Slider m_Slider;
    [Token(Token = "0x400F790")]
    [FieldOffset(Offset = "0x18")]
    [CustomField("イメージ", CustomFieldAttribute.Type.UIImage)]
    [CustomGroup("イメージ")]
    public Image m_Image;
    [Token(Token = "0x400F791")]
    [FieldOffset(Offset = "0x1C")]
    [CustomField("Rawイメージ", CustomFieldAttribute.Type.UIRawImage)]
    [CustomGroup("イメージ")]
    public RawImage m_RawImage;
    [Token(Token = "0x400F792")]
    [FieldOffset(Offset = "0x20")]
    [CustomField("イメージArray", CustomFieldAttribute.Type.ImageArray)]
    [CustomGroup("イメージ")]
    public ImageArray mImageArray;
    [Token(Token = "0x400F793")]
    [FieldOffset(Offset = "0x24")]
    [CustomField("イメージSpriteSheet", CustomFieldAttribute.Type.Component, typeof (ImageSpriteSheet), null)]
    [CustomGroup("イメージ")]
    public ImageSpriteSheet mImageSpriteSheet;
    [Token(Token = "0x400F794")]
    [FieldOffset(Offset = "0x28")]
    [CustomGroup("ゲームオブジェクト")]
    [CustomField("ゲームオブジェクト", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_TargetObject;
    [Token(Token = "0x400F795")]
    [FieldOffset(Offset = "0x2C")]
    [CustomField("スプライトシート", CustomFieldAttribute.Type.UISpriteSheet)]
    [CustomGroup("アセット")]
    public SpriteSheet m_SpriteSheet;
    [Token(Token = "0x400F796")]
    [FieldOffset(Offset = "0x30")]
    [CustomGroup("トグル")]
    [CustomField("トグル", CustomFieldAttribute.Type.UIToggle)]
    public Toggle m_Toggle;

    [Token(Token = "0x600E921")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public virtual void Initialize()
    {
    }

    [Token(Token = "0x600E922")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    public virtual void Release()
    {
    }

    [Token(Token = "0x600E923")]
    [Address(RVA = "0xAD72E0", Offset = "0xAD60E0", VA = "0x10AD72E0")]
    protected void SetText(string text)
    {
    }

    [Token(Token = "0x600E924")]
    [Address(RVA = "0xAD7360", Offset = "0xAD6160", VA = "0x10AD7360")]
    protected void SetText(object val)
    {
    }

    [Token(Token = "0x600E925")]
    [Address(RVA = "0xAD7280", Offset = "0xAD6080", VA = "0x10AD7280")]
    protected void SetTextColor(Color color)
    {
    }

    [Token(Token = "0x600E926")]
    [Address(RVA = "0xAD7120", Offset = "0xAD5F20", VA = "0x10AD7120")]
    protected void SetSprite(string key)
    {
    }

    [Token(Token = "0x600E927")]
    [Address(RVA = "0xAD71E0", Offset = "0xAD5FE0", VA = "0x10AD71E0")]
    protected void SetSprite(Sprite sprite)
    {
    }

    [Token(Token = "0x600E928")]
    [Address(RVA = "0xAD6FD0", Offset = "0xAD5DD0", VA = "0x10AD6FD0")]
    protected void SetRawImage(string path)
    {
    }

    [Token(Token = "0x600E929")]
    [Address(RVA = "0xAD6BF0", Offset = "0xAD59F0", VA = "0x10AD6BF0")]
    protected void SetImageColor(Color color)
    {
    }

    [Token(Token = "0x600E92A")]
    [Address(RVA = "0xAD6ED0", Offset = "0xAD5CD0", VA = "0x10AD6ED0")]
    protected void SetRawImageColor(Color color)
    {
    }

    [Token(Token = "0x600E92B")]
    [Address(RVA = "0xAD6CF0", Offset = "0xAD5AF0", VA = "0x10AD6CF0")]
    protected void SetImageIndex(int index)
    {
    }

    [Token(Token = "0x600E92C")]
    [Address(RVA = "0xAD6B40", Offset = "0xAD5940", VA = "0x10AD6B40")]
    protected void SetIconLoader(string path)
    {
    }

    [Token(Token = "0x600E92D")]
    [Address(RVA = "0xAD6D70", Offset = "0xAD5B70", VA = "0x10AD6D70")]
    protected void SetImageSpriteSheet(string key)
    {
    }

    [Token(Token = "0x600E92E")]
    [Address(RVA = "0xAD6AD0", Offset = "0xAD58D0", VA = "0x10AD6AD0")]
    protected void SetButtonInteractive(bool isActive)
    {
    }

    [Token(Token = "0x600E92F")]
    [Address(RVA = "0xAD7060", Offset = "0xAD5E60", VA = "0x10AD7060")]
    protected void SetSlider(float val, float min, float max)
    {
    }

    [Token(Token = "0x600E930")]
    [Address(RVA = "0xAD6A30", Offset = "0xAD5830", VA = "0x10AD6A30")]
    protected void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600E931")]
    [Address(RVA = "0xAD7460", Offset = "0xAD6260", VA = "0x10AD7460")]
    protected void SetToggleOn(bool isActive)
    {
    }

    [Token(Token = "0x600E932")]
    [Address(RVA = "0xAD7410", Offset = "0xAD6210", VA = "0x10AD7410")]
    protected void SetToggleOn(bool isActive, bool disableGroup)
    {
    }

    [Token(Token = "0x600E933")]
    [Address(RVA = "0xAD73A0", Offset = "0xAD61A0", VA = "0x10AD73A0")]
    protected void SetToggleInteractable(bool isActive)
    {
    }

    [Token(Token = "0x600E934")]
    [Address(RVA = "0xAD6DE0", Offset = "0xAD5BE0", VA = "0x10AD6DE0")]
    protected void SetMaterial(Material material)
    {
    }

    [Token(Token = "0x600E935")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BaseExhibit()
    {
    }
  }
}
