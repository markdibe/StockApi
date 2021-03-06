﻿using StockApi.BO;
using StockApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApi.Converters
{
    public class HolderImagesConverter
    {
        private ImageConverter iConverter;
        private HolderInformationConverter hiConverter;
        public HolderImagesConverter()
        {
            iConverter = new ImageConverter();
            hiConverter = new HolderInformationConverter();
        }

        public HolderImages Convert(HolderImagesBO holderImages)
        {
            if (holderImages == null) { return null; }
            HolderImages holder = new HolderImages
            {
                HolderId = holderImages.HolderId,
                HolderInformation = hiConverter.Convert(holderImages.HolderInformation),
                Id = holderImages.Id,
                Image = iConverter.Convert(holderImages.Image),
                ImageId = holderImages.ImageId
            };
            return holder;
        }

        public HolderImagesBO Convert(HolderImages holderImages)
        {
            if (holderImages == null) { return null; }
            HolderImagesBO holder = new HolderImagesBO
            {
                HolderId = holderImages.HolderId,
                HolderInformation = hiConverter.Convert(holderImages.HolderInformation),
                Id = holderImages.Id,
                Image = iConverter.Convert(holderImages.Image),
                ImageId = holderImages.ImageId
            };
            return holder;
        }

        public List<HolderImages> Convert(List<HolderImagesBO> holderImages)
        {
            if (holderImages == null) { return null; }
            return holderImages.Select(x => Convert(x)).ToList();
        }

        public List<HolderImagesBO> Convert(List<HolderImages> holderImages)
        {
            if (holderImages == null) { return null; }
            return holderImages.Select(x => Convert(x)).ToList();
        }
    }
}
