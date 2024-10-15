// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyRecordTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B7F")]
  [AddComponentMenu("UI/TrophyRecordTab")]
  public class TrophyRecordTab : MonoBehaviour
  {
    [Token(Token = "0x400D533")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Badge;
    [Token(Token = "0x400D534")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image Body;
    [Token(Token = "0x400D535")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text Text;
    [Token(Token = "0x400D536")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Cursor;
    [Token(Token = "0x400D537")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image Banner;
    [Token(Token = "0x400D538")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public TrophyCategoryData CategoryData;
    [Token(Token = "0x400D539")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public int Index;

    [Token(Token = "0x17001A79")]
    public int HashCode
    {
      [Token(Token = "0x600C78D"), Address(RVA = "0x902FA0", Offset = "0x901DA0", VA = "0x10902FA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C78E")]
    [Address(RVA = "0x902C10", Offset = "0x901A10", VA = "0x10902C10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C78F")]
    [Address(RVA = "0x902CC0", Offset = "0x901AC0", VA = "0x10902CC0")]
    public void Init(string title, Sprite banner = null)
    {
    }

    [Token(Token = "0x600C790")]
    [Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")]
    public void Setup(int _index)
    {
    }

    [Token(Token = "0x600C791")]
    [Address(RVA = "0x902E40", Offset = "0x901C40", VA = "0x10902E40")]
    public void RefreshDisplayParam()
    {
    }

    [Token(Token = "0x600C792")]
    [Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")]
    public void SetCategoryData(TrophyCategoryData _category_data)
    {
    }

    [Token(Token = "0x600C793")]
    [Address(RVA = "0x902F30", Offset = "0x901D30", VA = "0x10902F30")]
    public void SetCursor(bool isOn)
    {
    }

    [Token(Token = "0x600C794")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TrophyRecordTab()
    {
    }
  }
}
