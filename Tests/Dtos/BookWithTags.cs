﻿// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.Collections.Generic;
using DataLayer.EfClasses;
using GenericServices;

namespace Tests.Dtos
{
    public class BookWithTags : ILinkToEntity<Book>
    {
        public int BookId { get; set; }
        public ICollection<string> TagIds { get; set; }
    }
}