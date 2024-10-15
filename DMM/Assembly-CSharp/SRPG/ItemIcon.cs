// Decompiled with JetBrains decompiler
// Type: SRPG.ItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002658")]
  [AddComponentMenu("UI/ItemIcon")]
  public class ItemIcon : BaseIcon
  {
    [Token(Token = "0x400B347")]
    protected const string TooltipPath = "UI/ItemTooltip";
    [Token(Token = "0x400B348")]
    protected const string ICON_NAME_UNKNOWN = "IT_UNKNOWN";
    [Token(Token = "0x400B349")]
    [FieldOffset(Offset = "0xC")]
    [Space(10f)]
    public GameParameter.ItemInstanceTypes InstanceType;
    [Token(Token = "0x400B34A")]
    [FieldOffset(Offset = "0x10")]
    public int InstanceIndex;
    [Token(Token = "0x400B34B")]
    [FieldOffset(Offset = "0x14")]
    [Space(10f)]
    public RawImage Icon;
    [Token(Token = "0x400B34C")]
    [FieldOffset(Offset = "0x18")]
    public Image Frame;
    [Token(Token = "0x400B34D")]
    [FieldOffset(Offset = "0x1C")]
    public Text Num;
    [Token(Token = "0x400B34E")]
    [FieldOffset(Offset = "0x20")]
    public Slider NumSlider;
    [Token(Token = "0x400B34F")]
    [FieldOffset(Offset = "0x24")]
    public bool Tooltip;
    [Token(Token = "0x400B350")]
    [FieldOffset(Offset = "0x25")]
    public bool TapTooltip;
    [Token(Token = "0x400B351")]
    [FieldOffset(Offset = "0x28")]
    public Text HaveNum;
    [Token(Token = "0x400B352")]
    [FieldOffset(Offset = "0x2C")]
    public bool IsSecret;
    [Token(Token = "0x400B353")]
    [FieldOffset(Offset = "0x30")]
    protected ItemParam mSecretItemParam;
    [Token(Token = "0x400B354")]
    [FieldOffset(Offset = "0x34")]
    [Description("個数表記GameObjectへの参照")]
    public GameObject SecretAmount;
    [Token(Token = "0x400B355")]
    [FieldOffset(Offset = "0x38")]
    [Description("装備可能なユニットが存在する場合に表示状態を変更するバッジへの参照")]
    public Image SecretBadge;
    [Token(Token = "0x400B356")]
    [FieldOffset(Offset = "0x3C")]
    [Description("「？」アイコン⇒正規アイコン変更アニメ開始までの時間")]
    public float SecretWaitSec;
    [Token(Token = "0x400B357")]
    [FieldOffset(Offset = "0x40")]
    [Description("「？」アイコン⇒正規アイコン変更アニメトリガー名")]
    public string SecretAnimName;
    [Token(Token = "0x400B358")]
    [FieldOffset(Offset = "0x44")]
    [Description("「？」アイコン⇒正規アイコン変更アニメ開始後、アイコンを差し替えるまでの時間")]
    public float SecretAnimWaitSec;
    [Token(Token = "0x400B359")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Description("「？」期限付きアイテムを示すアイコンを表示するか")]
    private bool IsDispLimitedIcon;
    [Token(Token = "0x400B35A")]
    [FieldOffset(Offset = "0x4C")]
    [HeaderBar("▼刻印自動分解 分解アイコン")]
    [Space(10f)]
    public GameObject Disassembly;
    [Token(Token = "0x400B35B")]
    [FieldOffset(Offset = "0x50")]
    protected SRPG.Tooltip mTooltip;
    [Token(Token = "0x400B35C")]
    [FieldOffset(Offset = "0x54")]
    protected bool mReqExchgSecretIcon;

    [Token(Token = "0x170017F5")]
    public override bool HasTooltip
    {
      [Token(Token = "0x600AB33"), Address(RVA = "0x6E6F50", Offset = "0x6E5D50", VA = "0x106E6F50", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600AB34")]
    [Address(RVA = "0x6E6780", Offset = "0x6E5580", VA = "0x106E6780", Slot = "9")]
    protected override void ShowTooltip(Vector2 screen)
    {
    }

    [Token(Token = "0x600AB35")]
    [Address(RVA = "0x6E6760", Offset = "0x6E5560", VA = "0x106E6760", Slot = "10")]
    protected override void ShowTooltipByTap(Vector2 _screen)
    {
    }

    [Token(Token = "0x600AB36")]
    [Address(RVA = "0x6E5B60", Offset = "0x6E4960", VA = "0x106E5B60")]
    private void CreateTooltip(Vector2 screen, bool _is_tap)
    {
    }

    [Token(Token = "0x600AB37")]
    [Address(RVA = "0x6E61E0", Offset = "0x6E4FE0", VA = "0x106E61E0", Slot = "11")]
    public override void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600AB38")]
    [Address(RVA = "0x6E67A0", Offset = "0x6E55A0", VA = "0x106E67A0", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x600AB39")]
    [Address(RVA = "0x6E60D0", Offset = "0x6E4ED0", VA = "0x106E60D0", Slot = "13")]
    public virtual void ExchgSecretIcon()
    {
    }

    [Token(Token = "0x600AB3A")]
    [Address(RVA = "0x6E6EE0", Offset = "0x6E5CE0", VA = "0x106E6EE0", Slot = "14")]
    protected virtual IEnumerator exchgSecretIcon() => (IEnumerator) null;

    [Token(Token = "0x600AB3B")]
    [Address(RVA = "0x6E63C0", Offset = "0x6E51C0", VA = "0x106E63C0")]
    protected void SetTapTooltip(bool isValue)
    {
    }

    [Token(Token = "0x600AB3C")]
    [Address(RVA = "0x6E6110", Offset = "0x6E4F10", VA = "0x106E6110")]
    protected void OnDestroy()
    {
    }

    [Token(Token = "0x600AB3D")]
    [Address(RVA = "0x6E63D0", Offset = "0x6E51D0", VA = "0x106E63D0")]
    public void Setup(ItemData itemData)
    {
    }

    [Token(Token = "0x600AB3E")]
    [Address(RVA = "0x6E6E80", Offset = "0x6E5C80", VA = "0x106E6E80")]
    public ItemIcon()
    {
    }
  }
}
