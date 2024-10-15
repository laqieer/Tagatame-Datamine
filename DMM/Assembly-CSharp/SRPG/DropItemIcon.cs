// Decompiled with JetBrains decompiler
// Type: SRPG.DropItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002302")]
  [AddComponentMenu("UI/DropItemIcon")]
  public class DropItemIcon : ItemIcon
  {
    [Token(Token = "0x4009C4C")]
    [FieldOffset(Offset = "0x58")]
    private ConceptCardParam mSecretConceptCardParam;
    [Token(Token = "0x4009C4D")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private bool IsUpdateValueWithSecretFlag;

    [Token(Token = "0x17001502")]
    public override bool HasTooltip
    {
      [Token(Token = "0x6009699"), Address(RVA = "0x596CF0", Offset = "0x595AF0", VA = "0x10596CF0", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600969A")]
    [Address(RVA = "0x5963A0", Offset = "0x5951A0", VA = "0x105963A0", Slot = "9")]
    protected override void ShowTooltip(Vector2 screen)
    {
    }

    [Token(Token = "0x600969B")]
    [Address(RVA = "0x596380", Offset = "0x595180", VA = "0x10596380", Slot = "10")]
    protected override void ShowTooltipByTap(Vector2 _screen)
    {
    }

    [Token(Token = "0x600969C")]
    [Address(RVA = "0x594BE0", Offset = "0x5939E0", VA = "0x10594BE0")]
    private void CreateTooltip(Vector2 _screen, bool _is_tap)
    {
    }

    [Token(Token = "0x600969D")]
    [Address(RVA = "0x596540", Offset = "0x595340", VA = "0x10596540", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x600969E")]
    [Address(RVA = "0x595F50", Offset = "0x594D50", VA = "0x10595F50")]
    private void Refresh_Item(ItemParam param)
    {
    }

    [Token(Token = "0x600969F")]
    [Address(RVA = "0x5958E0", Offset = "0x5946E0", VA = "0x105958E0")]
    private void Refresh_ConceptCard(ConceptCardParam param)
    {
    }

    [Token(Token = "0x60096A0")]
    [Address(RVA = "0x595A60", Offset = "0x594860", VA = "0x10595A60")]
    private void Refresh_DropItem(QuestResult.DropItemData data)
    {
    }

    [Token(Token = "0x60096A1")]
    [Address(RVA = "0x5961C0", Offset = "0x594FC0", VA = "0x105961C0")]
    private void SetFrameSprite(ItemParam param, bool isSecret)
    {
    }

    [Token(Token = "0x60096A2")]
    [Address(RVA = "0x5960C0", Offset = "0x594EC0", VA = "0x105960C0")]
    private void SetFrameSprite(ConceptCardParam param, bool isSecret)
    {
    }

    [Token(Token = "0x60096A3")]
    [Address(RVA = "0x5962E0", Offset = "0x5950E0", VA = "0x105962E0")]
    private void SetIconAsync(ItemParam param, bool isSecret)
    {
    }

    [Token(Token = "0x60096A4")]
    [Address(RVA = "0x596240", Offset = "0x595040", VA = "0x10596240")]
    private void SetIconAsync(ConceptCardParam param, bool isSecret)
    {
    }

    [Token(Token = "0x60096A5")]
    [Address(RVA = "0x595820", Offset = "0x594620", VA = "0x10595820")]
    private void LoadIcon(ItemParam param, bool isSecret)
    {
    }

    [Token(Token = "0x60096A6")]
    [Address(RVA = "0x595760", Offset = "0x594560", VA = "0x10595760")]
    private void LoadIcon(ConceptCardParam param, bool isSecret)
    {
    }

    [Token(Token = "0x60096A7")]
    [Address(RVA = "0x5963C0", Offset = "0x5951C0", VA = "0x105963C0")]
    private void SwapIconFramePriority(bool iconIsTop)
    {
    }

    [Token(Token = "0x60096A8")]
    [Address(RVA = "0x595610", Offset = "0x594410", VA = "0x10595610")]
    private void GetParam(
      ref ConceptCardParam conceptCardParam,
      ref QuestResult.DropItemData dropItemData)
    {
    }

    [Token(Token = "0x60096A9")]
    [Address(RVA = "0x595710", Offset = "0x594510", VA = "0x10595710")]
    private string GetSecretIconPath() => (string) null;

    [Token(Token = "0x60096AA")]
    [Address(RVA = "0x595460", Offset = "0x594260", VA = "0x10595460")]
    private string GetIconPath(ItemData data, bool isSecret) => (string) null;

    [Token(Token = "0x60096AB")]
    [Address(RVA = "0x595550", Offset = "0x594350", VA = "0x10595550")]
    private string GetIconPath(ItemParam param, bool isSecret) => (string) null;

    [Token(Token = "0x60096AC")]
    [Address(RVA = "0x595490", Offset = "0x594290", VA = "0x10595490")]
    private string GetIconPath(ConceptCardParam param, bool isSecret) => (string) null;

    [Token(Token = "0x60096AD")]
    [Address(RVA = "0x5956A0", Offset = "0x5944A0", VA = "0x105956A0")]
    private Sprite GetSecretFrameSprite(Sprite defaultSprite) => (Sprite) null;

    [Token(Token = "0x60096AE")]
    [Address(RVA = "0x595200", Offset = "0x594000", VA = "0x10595200")]
    private Sprite GetFrameSprite(ItemData data, bool isSecret) => (Sprite) null;

    [Token(Token = "0x60096AF")]
    [Address(RVA = "0x5952F0", Offset = "0x5940F0", VA = "0x105952F0")]
    private Sprite GetFrameSprite(ItemParam param, bool isSecret) => (Sprite) null;

    [Token(Token = "0x60096B0")]
    [Address(RVA = "0x595230", Offset = "0x594030", VA = "0x10595230")]
    private Sprite GetFrameSprite(ConceptCardParam param, bool isSecret) => (Sprite) null;

    [Token(Token = "0x60096B1")]
    [Address(RVA = "0x5953B0", Offset = "0x5941B0", VA = "0x105953B0")]
    private int GetHaveNum(ItemParam param, int default_value) => new int();

    [Token(Token = "0x60096B2")]
    [Address(RVA = "0x5953A0", Offset = "0x5941A0", VA = "0x105953A0")]
    private int GetHaveNum(ConceptCardParam param, int default_value) => new int();

    [Token(Token = "0x60096B3")]
    [Address(RVA = "0x5951B0", Offset = "0x593FB0", VA = "0x105951B0", Slot = "13")]
    public override void ExchgSecretIcon()
    {
    }

    [Token(Token = "0x60096B4")]
    [Address(RVA = "0x596C80", Offset = "0x595A80", VA = "0x10596C80", Slot = "14")]
    protected override IEnumerator exchgSecretIcon() => (IEnumerator) null;

    [Token(Token = "0x60096B5")]
    [Address(RVA = "0x596C70", Offset = "0x595A70", VA = "0x10596C70")]
    public DropItemIcon()
    {
    }
  }
}
