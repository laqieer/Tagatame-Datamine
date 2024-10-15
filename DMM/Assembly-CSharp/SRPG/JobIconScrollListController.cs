// Decompiled with JetBrains decompiler
// Type: SRPG.JobIconScrollListController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002665")]
  [AddComponentMenu("UI/JobIconScrollListController")]
  public class JobIconScrollListController : MonoBehaviour
  {
    [Token(Token = "0x400B37C")]
    [FieldOffset(Offset = "0xC")]
    private float ITEM_DISTANCE;
    [Token(Token = "0x400B37D")]
    [FieldOffset(Offset = "0x10")]
    private float SINGLE_ICON_ZERO_MERGIN;
    [Token(Token = "0x400B37E")]
    [FieldOffset(Offset = "0x14")]
    private float SINGLE_ICON_ONE_MERGIN;
    [Token(Token = "0x400B37F")]
    [FieldOffset(Offset = "0x18")]
    private float SINGLE_ICON_TWO_MERGIN;
    [Token(Token = "0x400B380")]
    [FieldOffset(Offset = "0x1C")]
    private float SINGLE_ICON_THREE_MERGIN;
    [Token(Token = "0x400B381")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mTemplateItem;
    [Token(Token = "0x400B382")]
    [FieldOffset(Offset = "0x24")]
    [Range(0.0f, 30f)]
    [SerializeField]
    protected int m_ItemCnt;
    [Token(Token = "0x400B383")]
    [FieldOffset(Offset = "0x28")]
    public JobIconScrollListController.OnItemPositionChange OnItemUpdate;
    [Token(Token = "0x400B384")]
    [FieldOffset(Offset = "0x2C")]
    public JobIconScrollListController.OnAfterStartUpEvent OnAfterStartup;
    [Token(Token = "0x400B385")]
    [FieldOffset(Offset = "0x30")]
    public JobIconScrollListController.OnUpdateEvent OnUpdateItemEvent;
    [Token(Token = "0x400B386")]
    [FieldOffset(Offset = "0x34")]
    public JobIconScrollListController.OnItemPositionAreaOverEvent OnItemPositionAreaOver;
    [Token(Token = "0x400B387")]
    [FieldOffset(Offset = "0x38")]
    public JobIconScrollListController.Direction m_Direction;
    [Token(Token = "0x400B388")]
    [FieldOffset(Offset = "0x3C")]
    public JobIconScrollListController.Mode m_ScrollMode;
    [Token(Token = "0x400B389")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform m_RectTransform;
    [Token(Token = "0x400B38A")]
    [FieldOffset(Offset = "0x44")]
    private List<JobIconScrollListController.ItemData> mItems;
    [Token(Token = "0x400B38B")]
    [FieldOffset(Offset = "0x48")]
    private Rect mViewArea;
    [Token(Token = "0x400B38C")]
    [FieldOffset(Offset = "0x58")]
    private float mPreAnchoredPositionX;
    [Token(Token = "0x400B38D")]
    [FieldOffset(Offset = "0x5C")]
    private bool IsInitialized;
    [Token(Token = "0x400B38E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private RectTransform mViewPort;

    [Token(Token = "0x170017FB")]
    protected RectTransform GetRectTransForm
    {
      [Token(Token = "0x600AB7F"), Address(RVA = "0x6EB400", Offset = "0x6EA200", VA = "0x106EB400")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170017FC")]
    public float AnchoredPosition
    {
      [Token(Token = "0x600AB80"), Address(RVA = "0x6EB360", Offset = "0x6EA160", VA = "0x106EB360")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170017FD")]
    public float ScrollDir
    {
      [Token(Token = "0x600AB81"), Address(RVA = "0x6EB480", Offset = "0x6EA280", VA = "0x106EB480")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170017FE")]
    public List<JobIconScrollListController.ItemData> Items
    {
      [Token(Token = "0x600AB82"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (List<JobIconScrollListController.ItemData>) null;
      }
    }

    [Token(Token = "0x600AB83")]
    [Address(RVA = "0x6EA320", Offset = "0x6E9120", VA = "0x106EA320")]
    private void Start()
    {
    }

    [Token(Token = "0x600AB84")]
    [Address(RVA = "0x6E9D80", Offset = "0x6E8B80", VA = "0x106E9D80")]
    public void Init()
    {
    }

    [Token(Token = "0x600AB85")]
    [Address(RVA = "0x6E97A0", Offset = "0x6E85A0", VA = "0x106E97A0")]
    public void CreateInstance()
    {
    }

    [Token(Token = "0x600AB86")]
    [Address(RVA = "0x6E9DC0", Offset = "0x6E8BC0", VA = "0x106E9DC0")]
    public void Repotision()
    {
    }

    [Token(Token = "0x600AB87")]
    [Address(RVA = "0x6E96D0", Offset = "0x6E84D0", VA = "0x106E96D0")]
    private bool CheckRightAreaOut(JobIconScrollListController.ItemData item) => new bool();

    [Token(Token = "0x600AB88")]
    [Address(RVA = "0x6E9600", Offset = "0x6E8400", VA = "0x106E9600")]
    private bool CheckLeftAreaOut(JobIconScrollListController.ItemData item) => new bool();

    [Token(Token = "0x600AB89")]
    [Address(RVA = "0x6EB000", Offset = "0x6E9E00", VA = "0x106EB000")]
    private void Update()
    {
    }

    [Token(Token = "0x600AB8A")]
    [Address(RVA = "0x6EAE50", Offset = "0x6E9C50", VA = "0x106EAE50")]
    private void UpdateModeNormal()
    {
    }

    [Token(Token = "0x600AB8B")]
    [Address(RVA = "0x6EAF20", Offset = "0x6E9D20", VA = "0x106EAF20")]
    private void UpdateModeReverse()
    {
    }

    [Token(Token = "0x600AB8C")]
    [Address(RVA = "0x6EA960", Offset = "0x6E9760", VA = "0x106EA960")]
    private void UpdateItemsPositionReverse(bool is_move_right, bool is_move_left)
    {
    }

    [Token(Token = "0x600AB8D")]
    [Address(RVA = "0x6EA390", Offset = "0x6E9190", VA = "0x106EA390")]
    private void UpdateItemsPositionNormal(bool is_move_right, bool is_move_left)
    {
    }

    [Token(Token = "0x600AB8E")]
    [Address(RVA = "0x6EA380", Offset = "0x6E9180", VA = "0x106EA380")]
    public void Step()
    {
    }

    [Token(Token = "0x600AB8F")]
    [Address(RVA = "0x6EB1A0", Offset = "0x6E9FA0", VA = "0x106EB1A0")]
    public JobIconScrollListController()
    {
    }

    [Token(Token = "0x2002666")]
    [Serializable]
    public class OnItemPositionChange : UnityEvent<int, GameObject>
    {
      [Token(Token = "0x600AB90")]
      [Address(RVA = "0x6F17E0", Offset = "0x6F05E0", VA = "0x106F17E0")]
      public OnItemPositionChange()
      {
      }
    }

    [Token(Token = "0x2002667")]
    [Serializable]
    public class OnAfterStartUpEvent : UnityEvent<bool>
    {
      [Token(Token = "0x600AB91")]
      [Address(RVA = "0x6F1760", Offset = "0x6F0560", VA = "0x106F1760")]
      public OnAfterStartUpEvent()
      {
      }
    }

    [Token(Token = "0x2002668")]
    [Serializable]
    public class OnUpdateEvent : UnityEvent<List<JobIconScrollListController.ItemData>>
    {
      [Token(Token = "0x600AB92")]
      [Address(RVA = "0x6F1820", Offset = "0x6F0620", VA = "0x106F1820")]
      public OnUpdateEvent()
      {
      }
    }

    [Token(Token = "0x2002669")]
    [Serializable]
    public class OnItemPositionAreaOverEvent : UnityEvent<GameObject>
    {
      [Token(Token = "0x600AB93")]
      [Address(RVA = "0x6F17A0", Offset = "0x6F05A0", VA = "0x106F17A0")]
      public OnItemPositionAreaOverEvent()
      {
      }
    }

    [Token(Token = "0x200266A")]
    public enum Direction
    {
      [Token(Token = "0x400B390")] Vertical,
      [Token(Token = "0x400B391")] Horizontal,
    }

    [Token(Token = "0x200266B")]
    public enum Mode
    {
      [Token(Token = "0x400B393")] Normal,
      [Token(Token = "0x400B394")] Reverse,
    }

    [Token(Token = "0x200266C")]
    public class ItemData
    {
      [Token(Token = "0x400B395")]
      [FieldOffset(Offset = "0x8")]
      public GameObject gameObject;
      [Token(Token = "0x400B396")]
      [FieldOffset(Offset = "0xC")]
      public RectTransform rectTransform;
      [Token(Token = "0x400B397")]
      [FieldOffset(Offset = "0x10")]
      public Vector2 position;
      [Token(Token = "0x400B398")]
      [FieldOffset(Offset = "0x18")]
      public UnitInventoryJobIcon job_icon;

      [Token(Token = "0x600AB94")]
      [Address(RVA = "0x6E58D0", Offset = "0x6E46D0", VA = "0x106E58D0")]
      public ItemData(GameObject obj)
      {
      }
    }
  }
}
