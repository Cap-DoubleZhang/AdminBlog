﻿using Core.Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    /// <summary>
    /// 分页查找
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageModel<T> : IPageModel<T>
    {
        public static readonly IPageModel<T> Empty = new PageModel<T>();

        private IReadOnlyList<T> _data = Array.Empty<T>();

        [NotNull]
        public IReadOnlyList<T> Data
        {
            get => _data;
            set
            {
                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                if (value != null)
                {
                    _data = value;
                }
            }
        }

        private int _pageIndex = 1;

        public int PageIndex
        {
            get => _pageIndex;
            set
            {
                if (value > 0)
                {
                    _pageIndex = value;
                }
            }
        }

        private int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            set
            {
                if (value > 0)
                {
                    _pageSize = value;
                }
            }
        }

        private long _totalCount;

        public long TotalCount
        {
            get => _totalCount;
            set
            {
                if (value > 0)
                {
                    _totalCount = value;
                }
            }
        }

        public int PageCount => (int)((_totalCount + _pageSize - 1) / _pageSize);

        public T this[int index] => Data[index];

        public int Count => Data.Count;
    }
}
