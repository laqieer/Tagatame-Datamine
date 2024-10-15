// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyRecordPullView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B7D")]
  [AddComponentMenu("UI/TrophyRecordPullView")]
  public class TrophyRecordPullView : SRPG_ListBase
  {
    [Token(Token = "0x400D50C")]
    [FieldOffset(Offset = "0x20")]
    private float FRAME_MERGIN;
    [Token(Token = "0x400D50D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int CREATE_CHILD_COUNT;
    [Token(Token = "0x400D50E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] original_objects;
    [Token(Token = "0x400D50F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject badge;
    [Token(Token = "0x400D510")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private VerticalLayoutGroup vertical_layout_group;
    [Token(Token = "0x400D511")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Transform contents_parent;
    [Token(Token = "0x400D512")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LayoutElement root_layout_element;
    [Token(Token = "0x400D513")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private RectTransform view_port_rect;
    [Token(Token = "0x400D514")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RectTransform grid_rect;
    [Token(Token = "0x400D515")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private RectTransform contents_transform;
    [Token(Token = "0x400D516")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RectTransform button_open_rect;
    [Token(Token = "0x400D517")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private RectTransform button_close_rect;
    [Token(Token = "0x400D518")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BitmapText comp_trophy_count_text;
    [Token(Token = "0x400D519")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private BitmapText total_trophy_count_text;
    [Token(Token = "0x400D51A")]
    [FieldOffset(Offset = "0x58")]
    private TrophyRecordPullView.eState state;
    [Token(Token = "0x400D51B")]
    [FieldOffset(Offset = "0x5C")]
    private TrophyCategoryData category_data;
    [Token(Token = "0x400D51C")]
    [FieldOffset(Offset = "0x60")]
    private TrophyList trophy_list;
    [Token(Token = "0x400D51D")]
    [FieldOffset(Offset = "0x64")]
    private int comp_trophy_count;
    [Token(Token = "0x400D51E")]
    [FieldOffset(Offset = "0x68")]
    private int index;
    [Token(Token = "0x400D51F")]
    [FieldOffset(Offset = "0x6C")]
    private float item_distance;
    [Token(Token = "0x400D520")]
    [FieldOffset(Offset = "0x70")]
    private float view_mergin;
    [Token(Token = "0x400D521")]
    [FieldOffset(Offset = "0x74")]
    private float start_button_open_size;
    [Token(Token = "0x400D522")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private float CLOSE_SECOND;
    [Token(Token = "0x400D523")]
    [FieldOffset(Offset = "0x7C")]
    private Vector2 start_pos;
    [Token(Token = "0x400D524")]
    [FieldOffset(Offset = "0x84")]
    private Vector2 target_pos;
    [Token(Token = "0x400D525")]
    [FieldOffset(Offset = "0x8C")]
    private float default_min_height;
    [Token(Token = "0x400D526")]
    [FieldOffset(Offset = "0x90")]
    private float target_view_port_size;
    [Token(Token = "0x400D527")]
    [FieldOffset(Offset = "0x94")]
    private float anim_speed;
    [Token(Token = "0x400D528")]
    [FieldOffset(Offset = "0x98")]
    private float move_value;
    [Token(Token = "0x400D529")]
    [FieldOffset(Offset = "0x9C")]
    private float DEFAULT_OPEN_SPEED_AREA;
    [Token(Token = "0x400D52A")]
    [FieldOffset(Offset = "0xA0")]
    private float OPEN_SPEED;
    [Token(Token = "0x400D52B")]
    [FieldOffset(Offset = "0xA4")]
    private float HI_OPEN_SPEED;
    [Token(Token = "0x400D52C")]
    [FieldOffset(Offset = "0xA8")]
    private float HI_CLOSE_SPEED;

    [Token(Token = "0x17001A6E")]
    private TrophyRecordPullView.eState State
    {
      [Token(Token = "0x600C76B"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new TrophyRecordPullView.eState();
      }
    }

    [Token(Token = "0x17001A6F")]
    public int HashCode
    {
      [Token(Token = "0x600C76C"), Address(RVA = "0x902B10", Offset = "0x901910", VA = "0x10902B10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A70")]
    public bool IsStateOpen
    {
      [Token(Token = "0x600C76D"), Address(RVA = "0x902B60", Offset = "0x901960", VA = "0x10902B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001A71")]
    public bool IsStateOpened
    {
      [Token(Token = "0x600C76E"), Address(RVA = "0x902B80", Offset = "0x901980", VA = "0x10902B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001A72")]
    public bool IsStateClose
    {
      [Token(Token = "0x600C76F"), Address(RVA = "0x902B30", Offset = "0x901930", VA = "0x10902B30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001A73")]
    public bool IsStateClosed
    {
      [Token(Token = "0x600C770"), Address(RVA = "0x902B50", Offset = "0x901950", VA = "0x10902B50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001A74")]
    public float RootLayoutElementMinHeightDef
    {
      [Token(Token = "0x600C771"), Address(RVA = "0x902BA0", Offset = "0x9019A0", VA = "0x10902BA0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001A75")]
    public int Index
    {
      [Token(Token = "0x600C772"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A76")]
    public float ItemDistance
    {
      [Token(Token = "0x600C773"), Address(RVA = "0x902B90", Offset = "0x901990", VA = "0x10902B90")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001A77")]
    public float TargetViewPortSize
    {
      [Token(Token = "0x600C774"), Address(RVA = "0x902BE0", Offset = "0x9019E0", VA = "0x10902BE0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001A78")]
    public float VerticalLayoutSpacing
    {
      [Token(Token = "0x600C775"), Address(RVA = "0x902BF0", Offset = "0x9019F0", VA = "0x10902BF0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600C776")]
    [Address(RVA = "0x901B00", Offset = "0x900900", VA = "0x10901B00", Slot = "5")]
    protected override RectTransform GetRectTransform() => (RectTransform) null;

    [Token(Token = "0x600C777")]
    [Address(RVA = "0x9011D0", Offset = "0x8FFFD0", VA = "0x109011D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C778")]
    [Address(RVA = "0x902750", Offset = "0x901550", VA = "0x10902750")]
    private void Update()
    {
    }

    [Token(Token = "0x600C779")]
    [Address(RVA = "0x901B50", Offset = "0x900950", VA = "0x10901B50")]
    public void Init(string _title_str)
    {
    }

    [Token(Token = "0x600C77A")]
    [Address(RVA = "0x902170", Offset = "0x900F70", VA = "0x10902170")]
    public void Setup(int _index, TrophyList _trophy_list)
    {
    }

    [Token(Token = "0x600C77B")]
    [Address(RVA = "0x525C30", Offset = "0x524A30", VA = "0x10525C30")]
    public void SetCategoryData(TrophyCategoryData _category_data)
    {
    }

    [Token(Token = "0x600C77C")]
    [Address(RVA = "0x901F10", Offset = "0x900D10", VA = "0x10901F10")]
    public void Refresh(RectTransform _scroll_trans_rect)
    {
    }

    [Token(Token = "0x600C77D")]
    [Address(RVA = "0x901D10", Offset = "0x900B10", VA = "0x10901D10")]
    public void RefreshDisplayParam()
    {
    }

    [Token(Token = "0x600C77E")]
    [Address(RVA = "0x902350", Offset = "0x901150", VA = "0x10902350")]
    public void StartOpen()
    {
    }

    [Token(Token = "0x600C77F")]
    [Address(RVA = "0x901A10", Offset = "0x900810", VA = "0x10901A10")]
    private void EndOpen()
    {
    }

    [Token(Token = "0x600C780")]
    [Address(RVA = "0x9025A0", Offset = "0x9013A0", VA = "0x109025A0")]
    private void UpdateOpen()
    {
    }

    [Token(Token = "0x600C781")]
    [Address(RVA = "0x902250", Offset = "0x901050", VA = "0x10902250")]
    public void StartClose()
    {
    }

    [Token(Token = "0x600C782")]
    [Address(RVA = "0x901950", Offset = "0x900750", VA = "0x10901950")]
    private void EndClose()
    {
    }

    [Token(Token = "0x600C783")]
    [Address(RVA = "0x902410", Offset = "0x901210", VA = "0x10902410")]
    private void UpdateClose()
    {
    }

    [Token(Token = "0x600C784")]
    [Address(RVA = "0x9022E0", Offset = "0x9010E0", VA = "0x109022E0")]
    private void StartClosed()
    {
    }

    [Token(Token = "0x600C785")]
    [Address(RVA = "0x9021F0", Offset = "0x900FF0", VA = "0x109021F0")]
    protected void StartCloseImmediate()
    {
    }

    [Token(Token = "0x600C786")]
    [Address(RVA = "0x901950", Offset = "0x900750", VA = "0x10901950")]
    protected void EndCloseImmediate()
    {
    }

    [Token(Token = "0x600C787")]
    [Address(RVA = "0x9023F0", Offset = "0x9011F0", VA = "0x109023F0")]
    protected void UpdateCloseImmediate()
    {
    }

    [Token(Token = "0x600C788")]
    [Address(RVA = "0x9014E0", Offset = "0x9002E0", VA = "0x109014E0")]
    public void CreateContents()
    {
    }

    [Token(Token = "0x600C789")]
    [Address(RVA = "0x901720", Offset = "0x900520", VA = "0x10901720")]
    private List<GameObject> CreateInstances() => (List<GameObject>) null;

    [Token(Token = "0x600C78A")]
    [Address(RVA = "0x901290", Offset = "0x900090", VA = "0x10901290")]
    public void ChangeState(TrophyRecordPullView.eState _new_state)
    {
    }

    [Token(Token = "0x600C78B")]
    [Address(RVA = "0x901CB0", Offset = "0x900AB0", VA = "0x10901CB0")]
    public void OnClickEvent()
    {
    }

    [Token(Token = "0x600C78C")]
    [Address(RVA = "0x902AB0", Offset = "0x9018B0", VA = "0x10902AB0")]
    public TrophyRecordPullView()
    {
    }

    [Token(Token = "0x2002B7E")]
    public enum eState
    {
      [Token(Token = "0x400D52E")] OPEN,
      [Token(Token = "0x400D52F")] OPENED,
      [Token(Token = "0x400D530")] CLOSE,
      [Token(Token = "0x400D531")] CLOSE_IMMEDIATE,
      [Token(Token = "0x400D532")] CLOSED,
    }
  }
}
