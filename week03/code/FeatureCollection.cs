public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Feature[] Features {get; set;}

}

public class Feature {
    public Property Properties {get; set;}
}

public class Property {
    public string Place {get; set;}
    public double Mag {get; set;}
}

