# Installation Instructions
 - Install Sitecore 9.0 update 2
 - Clone and open the solution source code from https://github.com/dch0706/companysite
 - Set you values for <SitecoreWebUrl> and <SitecoreDeployFolder> in TdsGlobal.config
 - Choose "Quick push all TDS Projects" for solution to restore content items.
 - Build the solution (all required files will be deployed by TDS)
 - Add the following website (IIS binding/record in hosts) for the recently instalaled SC instance: local.companysite.com
 - Copy the custom model to xConnect

    |source (solution)|destination|
    | ------ | ------ |
    |VanLanschot.Feature.VolleyGroup.XConnect.ContactCustomModel.json|<xConnect>\App_data\Models|
    ||<xConnect>\App_data\jobs\continuous\IndexWorker\App_data\Models|
    
 - Publish website
 - Enjoy the solution :)