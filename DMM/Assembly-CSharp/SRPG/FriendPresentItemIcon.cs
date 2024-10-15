// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023E5")]
  [AddComponentMenu("UI/FriendPresentItemIcon")]
  public class FriendPresentItemIcon : MonoBehaviour
  {
    [Token(Token = "0x400A250")]
    [FieldOffset(Offset = "0xC")]
    [CustomGroup("期間")]
    [CustomField("ルート", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_TimeLimitObject;
    [Token(Token = "0x400A251")]
    [FieldOffset(Offset = "0x10")]
    [CustomGroup("期間")]
    [CustomField("時間", CustomFieldAttribute.Type.UIText)]
    public GameObject m_TimeLimitValueObject;
    [Token(Token = "0x400A252")]
    [FieldOffset(Offset = "0x14")]
    [CustomGroup("アイテム")]
    [CustomField("名前", CustomFieldAttribute.Type.UIText)]
    public GameObject m_NameObject;
    [Token(Token = "0x400A253")]
    [FieldOffset(Offset = "0x18")]
    [CustomField("フレーム", CustomFieldAttribute.Type.UIImage)]
    [CustomGroup("アイテム")]
    public GameObject m_FrameObject;
    [Token(Token = "0x400A254")]
    [FieldOffset(Offset = "0x1C")]
    [CustomGroup("アイテム")]
    [CustomField("アイテムアイコン", CustomFieldAttribute.Type.UIRawImage)]
    public GameObject m_IconObject;
    [Token(Token = "0x400A255")]
    [FieldOffset(Offset = "0x20")]
    [CustomField("個数", CustomFieldAttribute.Type.UIText)]
    [CustomGroup("アイテム")]
    public GameObject m_AmountObject;
    [Token(Token = "0x400A256")]
    [FieldOffset(Offset = "0x24")]
    [CustomField("ゼニーアイコン", CustomFieldAttribute.Type.UIImage)]
    [CustomGroup("アイテム")]
    public GameObject m_CoinIconObject;
    [Token(Token = "0x400A257")]
    [FieldOffset(Offset = "0x28")]
    [CustomGroup("アイテム")]
    [CustomField("ゼニー", CustomFieldAttribute.Type.UIText)]
    public GameObject m_ZenyObject;
    [Token(Token = "0x400A258")]
    [FieldOffset(Offset = "0x2C")]
    [CustomGroup("アイテム")]
    [CustomField("設定テキスト", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_SettingTextObject;
    [Token(Token = "0x400A259")]
    [FieldOffset(Offset = "0x30")]
    [CustomGroup("所持数")]
    [CustomField("ルート", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_NumObject;
    [Token(Token = "0x400A25A")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("所持数")]
    [CustomField("個数", CustomFieldAttribute.Type.UIText)]
    public GameObject m_NumValueObject;
    [Token(Token = "0x400A25B")]
    [FieldOffset(Offset = "0x38")]
    private FriendPresentItemParam m_Present;
    [Token(Token = "0x400A25C")]
    [FieldOffset(Offset = "0x3C")]
    private ItemData m_ItemData;

    [Token(Token = "0x6009C15")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009C16")]
    [Address(RVA = "0x5F5B80", Offset = "0x5F4980", VA = "0x105F5B80")]
    public void Clear()
    {
    }

    [Token(Token = "0x6009C17")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009C18")]
    [Address(RVA = "0x5F5BC0", Offset = "0x5F49C0", VA = "0x105F5BC0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009C19")]
    [Address(RVA = "0x5F5930", Offset = "0x5F4730", VA = "0x105F5930")]
    public void Bind(FriendPresentItemParam present, bool checkTimeLimit)
    {
    }

    [Token(Token = "0x6009C1A")]
    [Address(RVA = "0x5F67D0", Offset = "0x5F55D0", VA = "0x105F67D0")]
    public void SetText(GameObject gobj, string text)
    {
    }

    [Token(Token = "0x6009C1B")]
    [Address(RVA = "0x5F6860", Offset = "0x5F5660", VA = "0x105F6860")]
    public void SetText(GameObject gobj, int num)
    {
    }

    [Token(Token = "0x6009C1C")]
    [Address(RVA = "0x5F6360", Offset = "0x5F5160", VA = "0x105F6360")]
    public void SetRestTime(GameObject gobj, long endTime)
    {
    }

    [Token(Token = "0x6009C1D")]
    [Address(RVA = "0x5F6740", Offset = "0x5F5540", VA = "0x105F6740")]
    public void SetSprite(GameObject gobj, Sprite sprite)
    {
    }

    [Token(Token = "0x6009C1E")]
    [Address(RVA = "0x5F6690", Offset = "0x5F5490", VA = "0x105F6690")]
    public void SetSprite(GameObject gobj, Sprite sprite, Color color)
    {
    }

    [Token(Token = "0x6009C1F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public FriendPresentItemIcon()
    {
    }
  }
}
